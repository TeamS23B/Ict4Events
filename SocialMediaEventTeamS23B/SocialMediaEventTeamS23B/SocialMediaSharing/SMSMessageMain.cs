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
        /// <summary>
        /// message main
        /// </summary>
        /// <param name="post"></param>
        /// <param name="dbConnection"></param>
        public SMSMessageMain(Post post,DataBaseConnection dbConnection)
        {
            InitializeComponent();
            Post = post;
            lblTitle.Text = post.Title;
            lblUsername.Text = post.Uploader;
            lblContent.Text = post.Description;
            this.dbConnection = dbConnection;
        }
        /// <summary>
        /// make a message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SMSMessageMain_DoubleClick(object sender, EventArgs e)
        {
            var smsShowMessage = new SMSShowMessage(Post, dbConnection);
            smsShowMessage.Show();
        }
    }
}
