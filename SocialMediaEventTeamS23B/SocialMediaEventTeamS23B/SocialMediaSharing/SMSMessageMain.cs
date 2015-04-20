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
    public partial class SMSMessageMain : UserControl,IMainItem
    {
        private static Dictionary<string,string> RfidUsernameCache = new Dictionary<string, string>();

        public Post Post { get; private set; }
        private DataBaseConnection dbConnection;

        private string username;

        /// <summary>
        /// message main
        /// </summary>
        /// <param name="post"></param>
        /// <param name="dbConnection"></param>
        public SMSMessageMain(Post post,DataBaseConnection dbConnection, string username)
        {
            InitializeComponent();
            Post = post;
            lblTitle.Text = post.Title;
            if (RfidUsernameCache.ContainsKey(post.Uploader))
            {

                lblUsername.Text = RfidUsernameCache[post.Uploader];
            }
            else
            {
                var name = dbConnection.GetUsernameFromRrid(post.Uploader);
                RfidUsernameCache.Add(post.Uploader,name);
                lblUsername.Text = name;

            }
            lblContent.Text = post.Description;
            this.dbConnection = dbConnection;
            this.username = username;
        }
        /// <summary>
        /// make a message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SMSMessageMain_DoubleClick(object sender, EventArgs e)
        {
            var smsShowMessage = new SMSShowMessage(Post, dbConnection,username);
            smsShowMessage.Show();
        }
    }
}
