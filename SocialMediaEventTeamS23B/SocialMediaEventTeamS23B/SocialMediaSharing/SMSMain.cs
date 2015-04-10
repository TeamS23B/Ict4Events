using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection.Types;
using ApplicationLayer;

namespace SocialMediaEventTeamS23B.SocialMediaSharing
{
    public partial class SMSMain : Form
    {
        public SMSMain(Visitor user)
        {
            InitializeComponent();
            this.user = user;
            lblUsername.Text = user.Username;
            
            Sms = new SocialMediaSharing(user.Username);
            messages=new List<SMSMessageMain>();
            trendingMessages=new List<SMSMesageMainMedia>();

            tmrRefresh.Enabled = true;
        }

        private Visitor user;
        private SocialMediaSharing Sms;

        private List<SMSMessageMain> messages; 
        private List<SMSMessageMain> trendingMessages;
        private List<SMSMessageMain> myMessages;

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            //checking for new content
            if (panel2.VerticalScroll.Value > panel2.VerticalScroll.Maximum - 300)
            {
                var newContent = Sms.CheckContent(messages.Last());
            foreach (Post content in newContent)
            {
                var obj = new SMSMessageMain(content);
                obj.Width = panel2.Width - 24;
                obj.Left = 12;
                    var lastMessage = messages.LastOrDefault();
                    if (lastMessage == null)
                        obj.Top = 12;
                    else
                obj.Top = lastMessage.Top + lastMessage.Height + 12;
                panel2.Controls.Add(obj);
            }

            }

            trendingMessages.ForEach(message=>panel3.Controls.Remove(message));
            trendingMessages.Clear();

            var topPosts = Sms.GetTopMessages();
            foreach (Post topPost in topPosts)
            {
                var obj = new SMSMessageMain(topPost);
                obj.Width = panel3.Width - 24;
                obj.Left = 12;
                var lastMessage = trendingMessages.LastOrDefault();
                if (lastMessage == null)
                    obj.Top = 12;
                else
                    obj.Top = lastMessage.Top + lastMessage.Height + 12;
                panel3.Controls.Add(obj);
            }

            myMessages.ForEach(message=>panel1.Controls.Remove(message));
            myMessages.Clear();

            var myPosts = Sms.GetMyPosts(user.Username);
            foreach (Post myPost in myPosts)
            {
                var obj = new SMSMessageMain(myPost);
                obj.Width = panel1.Width - 24;
                obj.Left = 12;
                var lastMessage = myMessages.LastOrDefault();
                if (lastMessage == null)
                    obj.Top = 12;
                else
                    obj.Top = lastMessage.Top + lastMessage.Height + 12;
                panel1.Controls.Add(obj);
            }
        }

    }
}
