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
    public partial class SMSMesageMainMedia : UserControl,IMainItem
    {
        public Post Post { get; private set; }
        private DataBaseConnection dbConnection;
        /// <summary>
        /// message main
        /// </summary>
        /// <param name="post"></param>
        /// <param name="dbConnection"></param>
        public SMSMesageMainMedia(Post post, DataBaseConnection dbConnection)
        {
            InitializeComponent();
            Post = post;
            lblTitle.Text = post.Title;
            lblUsername.Text = post.Uploader;
            lblContent.Text = post.Description;
            this.dbConnection = dbConnection;
            pictureBox1.Load("http://192.168.20.112/"+post.Mediafile.PathToFile);
        }

        /// <summary>
        /// make a message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SMSMessageMainMedia_DoubleClick(object sender, EventArgs e)
        {
            var smsShowMessage = new SMSShowMessage(Post, dbConnection);
            smsShowMessage.Show();
        }
    }
}
