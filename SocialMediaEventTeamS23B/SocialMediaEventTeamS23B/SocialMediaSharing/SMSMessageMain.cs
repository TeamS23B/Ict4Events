using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection;
using DatabaseConnection.Types;

namespace SocialMediaEventTeamS23B.SMSForms
{
    public partial class SMSMessageMain : UserControl
    {
        public Post Post { get; private set; }
        private DataBaseConnection dbConnection;

        public SMSMessageMain(Post post,DataBaseConnection dbConnection)
        {
            InitializeComponent();
            Post = post;
            lblTitle.Text = "";
            lblUsername.Text = post.Uploader;
            lblContent.Text = post.Description;
            this.dbConnection = dbConnection;
        }

        private void SMSMessageMain_DoubleClick(object sender, EventArgs e)
        {
            var smsShowMessage = new SMSShowMessage(Post, dbConnection);
            smsShowMessage.Show();
        }
    }
}
