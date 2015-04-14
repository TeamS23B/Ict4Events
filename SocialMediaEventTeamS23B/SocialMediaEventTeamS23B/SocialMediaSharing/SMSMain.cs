using System;
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
            messages=new List<SMSMessageMain>();
            loadPosts();
        }

        private Visitor user;
        private SocialMediaSharing Sms;

        private List<SMSMessageMain> messages; 

        private int lastIndex;
        
        private void loadPosts()
        {
            //checking for new content
            var newContent = Sms.GetPosts();
            foreach (Post content in newContent)
            {
                var obj = new SMSMessageMain(content,dbConnection);
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
                panel2.Controls.Add(obj);
                messages.Add(obj);
            }
        }

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
        
    }
}
