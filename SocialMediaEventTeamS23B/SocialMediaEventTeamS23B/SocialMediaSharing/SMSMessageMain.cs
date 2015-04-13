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
    public partial class SMSMessageMain : UserControl
    {
        public Post Post { get; private set; }

        public SMSMessageMain(Post post)
        {
            InitializeComponent();
            Post = post;
            lblTitle.Text = "";
            lblUsername.Text = post.Uploader;
            lblContent.Text = post.Description;
        }
    }
}
