using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection;
using DatabaseConnection.Types;

namespace SocialMediaEventTeamS23B.SMSForms
{
    public partial class SMSShowMessage : Form
    {
        public Post Post { get; private set; }
        private DataBaseConnection dbConnection;

        public SMSShowMessage(Post post, DataBaseConnection dbConnection)
        {
            Post = post;
            InitializeComponent();
            lblTitle.Text = post.Title;
            lblContent.Text = post.Description;
            lblUsername.Text = post.Uploader;
            this.dbConnection = dbConnection;
            LoadComments(Post,0);
        }

        private int nextYCord = 12;

        private void LoadComments(Post post,int indent)
        {
            if (post.Comments == null)
            {
                post.Comments = dbConnection.GetPostsOf(post.Id);
            }
            foreach (var comment in post.Comments)
            {
                var cmnt = new SMSShowMessageComment(comment);
                cmnt.Left = indent*12;
                cmnt.Top = nextYCord;
                cmnt.Width = pnlComments.Width - cmnt.Left - 12;
                nextYCord += cmnt.Height + 12;
                pnlComments.Controls.Add(cmnt);
                comment.Comments.ForEach(cmntOnCmnt => LoadComments(cmntOnCmnt, indent + 1));
            }
        }
    }
}
