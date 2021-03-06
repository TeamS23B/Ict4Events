﻿using System;
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
        private static Dictionary<string, string> RfidUsernameCache = new Dictionary<string, string>();

        public Post Post { get; private set; }
        private DataBaseConnection dbConnection;
        private string username;

        public SMSShowMessage(Post post, DataBaseConnection dbConnection, string username)
        {
            Post = post;
            InitializeComponent();
            lblTitle.Text = post.Title;
            lblContent.Text = post.Description;
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
            this.dbConnection = dbConnection;
            this.username = username;
            if (post.Mediafile != null)
            {
                lblComments.Top += 100;
                pnlComments.Height -= 100;
                pnlComments.Top += 100;
                var pb = new PictureBox();
                pb.Left = 12;
                pb.Width = this.Width - 24;
                pb.Top = lblContent.Top + lblContent.Height + 12;
                pb.Height = lblComments.Top - pb.Top - 12;
                pb.Load("http://192.168.20.112/"+post.Mediafile.PathToFile);
                pb.SizeMode=PictureBoxSizeMode.Zoom;
                Controls.Add(pb);
            }
            LoadComments(Post,dbConnection.GetPostId(post.Title));
        }

        private int nextYCord = 12;
        /// <summary>
        /// load comments
        /// </summary>
        /// <param name="post"></param>
        /// <param name="indent"></param>
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
                comment.Comments = dbConnection.GetPostsOf(comment.Id);
                comment.Comments.ForEach(cmntOnCmnt => LoadComments(cmntOnCmnt, indent + 1));
            }
        }

        private void btAddComment_Click(object sender, EventArgs e)
        {
            var postDiag = new SMSCreatePost(username);
            if (postDiag.ShowDialog() == DialogResult.OK)
            {
                dbConnection.AddPost(postDiag.Post.Uploader, 1, postDiag.Post.Title, postDiag.Post.Description, Post.Id,
                    DateTime.Now);
            }
        }
    }
}
