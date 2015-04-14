﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection.Types;

namespace SocialMediaEventTeamS23B.SMSForms
{
    public partial class SMSCreatePost : Form
    {
        private string username;

        public SMSCreatePost(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public Post Post { get; private set; }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Post=new Post(tbTitle.Text,new List<Post>(),tbText.Text,0,0,DateTime.Now,username,null,0 );
            DialogResult = DialogResult.OK;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var ofDiag = new OpenFileDialog()
            {
                Filter = @"Afbeeldingen (*.jpg,*.png)|*.jpg;*.png|Video's|*.mpg;*.avi"
            };
            if (ofDiag.ShowDialog() == DialogResult.OK)
            {
                tbAttatchment.Text = ofDiag.FileName;
            }
        
        }
    }
}
