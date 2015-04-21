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
        private static Dictionary<string, string> RfidUsernameCache = new Dictionary<string, string>();

        public Post Post { get; private set; }
        private DataBaseConnection dbConnection;
        private string username;
        private string loggedInRfid;
        /// <summary>
        /// message main
        /// </summary>
        /// <param name="post"></param>
        /// <param name="dbConnection"></param>
        public SMSMesageMainMedia(Post post, DataBaseConnection dbConnection,string username)
        {
            InitializeComponent();
            Post = post;
            lblTitle.Text = post.Title;
            lblLikes.Text = Convert.ToString(dbConnection.GetLikesFromPost(post.Title));
            lblFlags.Text = Convert.ToString(dbConnection.GetFlagsFromPost(post.Title));
            if (RfidUsernameCache.ContainsKey(post.Uploader))
            {

                lblUsername.Text = RfidUsernameCache[post.Uploader];
            }
            else
            {
                var name = dbConnection.GetUsernameFromRfid(post.Uploader);
                RfidUsernameCache.Add(post.Uploader, name);
                lblUsername.Text = name;

            }
            lblContent.Text = post.Description;
            this.dbConnection = dbConnection;
            pictureBox1.Load("http://192.168.20.112/"+post.Mediafile.PathToFile);
            this.username = username;
            this.loggedInRfid = dbConnection.GetRFIDFromUser(username);
        }

        /// <summary>
        /// make a message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SMSMessageMainMedia_DoubleClick(object sender, EventArgs e)
        {
            var smsShowMessage = new SMSShowMessage(Post, dbConnection,username);
            smsShowMessage.Show();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if (dbConnection.HasUserLikedOrFlagged(username, Post.Id) == true)
            {
                MessageBox.Show("Je hebt dit bericht al geliked / geflagged");
            }
            else
            {
                
                dbConnection.LikePost(username, Post.Title);
                decimal likes = dbConnection.GetLikesFromPost(Post.Title);
                lblLikes.Text = Convert.ToString(likes);        
            }
                
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            if (dbConnection.HasUserLikedOrFlagged(username, Post.Id) == true)
            {
                MessageBox.Show("Je hebt dit bericht al geliked / geflagged");
            }
            else
            {
                
                dbConnection.FlagPost(username, Post.Title);
                decimal flags = dbConnection.GetFlagsFromPost(Post.Title);
                lblFlags.Text = Convert.ToString(flags);
            }
            
        }
    }
}
