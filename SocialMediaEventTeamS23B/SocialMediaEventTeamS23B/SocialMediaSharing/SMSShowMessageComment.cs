using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection.Types;

namespace SocialMediaEventTeamS23B.SMSForms
{
    public partial class SMSShowMessageComment : UserControl
    {
        public Post Post { get; private set; }
        public SMSShowMessageComment(Post post)
        {
            Post = post;
            InitializeComponent();
            lblTitle.Text = post.Title;
            lblUsername.Text = post.Uploader;
            lblContent.Text = post.Description;
        }
    }
}
