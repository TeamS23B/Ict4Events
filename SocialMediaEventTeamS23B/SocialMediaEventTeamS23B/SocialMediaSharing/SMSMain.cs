﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLayer;
using DatabaseConnection;
using DatabaseConnection.Types;

namespace SocialMediaEventTeamS23B.SMSForms
{
    public partial class SMSMain : Form
    {
        private DataBaseConnection dbConnection;

        public SMSMain(DataBaseConnection dbConnection, Visitor user)
        {
            InitializeComponent();
            this.user = user;
            lblUsername.Text = user.Username;
            this.dbConnection = dbConnection;
            Sms = new SocialMediaSharing(dbConnection,user.Username);
            messages=new List<IMainItem>();
            loadPosts();
        }

        private Visitor user;
        private SocialMediaSharing Sms;

        private List<IMainItem> messages; 

        private int lastIndex;
        
        /// <summary>
        /// load the posts
        /// </summary>
        private void loadPosts()
        {
            //checking for new content
            var newContent = Sms.GetPosts();
            Console.WriteLine("Writing to form...");
            foreach (Post content in newContent)
            {
                Console.WriteLine(content.Title);
                IMainItem obj;
                if (content.Mediafile == null)
                {
                    obj = new SMSMessageMain(content, dbConnection,user.RFID);
                }
                else
                {
                    obj = new SMSMesageMainMedia(content, dbConnection, user.RFID);
                }
                obj.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                obj.Width = panel2.Width - 24;
                obj.Left = 12;
                var lastMessage = messages.LastOrDefault();
                if (lastMessage == null)
                {
                    obj.Top = 12;
                }
                else
                {
                    obj.Top = lastMessage.Top + lastMessage.Height + 12;
                }
                panel2.Controls.Add((Control)obj);
                messages.Add(obj);
            }
        }

        /// <summary>
        /// new message event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNewMessage_Click(object sender, EventArgs e)
        {
            var createPostFrm = new SMSCreatePost(user.RFID);
            if (createPostFrm.ShowDialog()==DialogResult.OK)
            {
                Sms.PostMessage(createPostFrm.Post);
                foreach (var smsMessageMain in messages)
                {
                    smsMessageMain.Dispose();
                }
                messages.Clear();
                loadPosts();
            }
            


        }

        private bool isClearedSearch = true;

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                if (!isClearedSearch)
                {
                    messages.ForEach(mes=>mes.BackColor=Color.White);
                    isClearedSearch = true;
                }
                return;
            }
            isClearedSearch = false;
            messages.ForEach(mes=>mes.BackColor=postContainsString(mes.Post,tbSearch.Text)?Color.LimeGreen:Color.White);
        }

        private bool postContainsString(Post post, string text)
        {
            return post.Title.IndexOf(text, StringComparison.OrdinalIgnoreCase)>=0||
            post.Description.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0;
        }
        
    }

    

    public interface IMainItem
    {
        int Top { get; set; }
        int Left { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        void Dispose();
        AnchorStyles Anchor { get; set; }

        Post Post { get; }
        Color BackColor { get; set; }
    }
}
