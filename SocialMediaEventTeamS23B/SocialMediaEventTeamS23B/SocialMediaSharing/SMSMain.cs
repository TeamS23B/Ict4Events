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
        public SMSMain(DataBaseConnection dbConnection, Visitor user)
        {
            InitializeComponent();
            this.user = user;
            lblUsername.Text = user.Username;
            
            Sms = new SocialMediaSharing(dbConnection,user.Username);
            messages=new List<SMSMessageMain>();

            tmrRefresh.Enabled = true;
        }

        private Visitor user;
        private SocialMediaSharing Sms;

        private List<SMSMessageMain> messages; 

        private int lastIndex;
        
        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            //checking for new content
            /*var newContent = Sms.CheckContent(lastIndex);
            foreach (Post content in newContent)
            {
                var obj = new SMSMessageMain(content);
                obj.Width = panel2.Width - 24;
                obj.Left = 12;
                var lastMessage = messages.Last();
                obj.Top = lastMessage.Top + lastMessage.Height + 12;
                panel2.Controls.Add(obj);
            }*/
        }

        private void SMSMain_Load(object sender, EventArgs e)
        {

        }
        
    }
}
