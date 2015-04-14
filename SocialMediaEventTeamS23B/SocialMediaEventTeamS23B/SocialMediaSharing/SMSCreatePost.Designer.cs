﻿namespace SocialMediaEventTeamS23B.SMSForms
{
    partial class SMSCreatePost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.tbAttatchment = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btSubCategorie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titel";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.CausesValidation = false;
            this.tbTitle.Location = new System.Drawing.Point(79, 12);
            this.tbTitle.MaxLength = 200;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(293, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.CausesValidation = false;
            this.tbText.Location = new System.Drawing.Point(79, 39);
            this.tbText.MaxLength = 2000;
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(293, 86);
            this.tbText.TabIndex = 2;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 46);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(34, 13);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Tekst";
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new System.Drawing.Point(12, 135);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(61, 13);
            this.lblAttachment.TabIndex = 4;
            this.lblAttachment.Text = "Attachment";
            // 
            // tbAttatchment
            // 
            this.tbAttatchment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAttatchment.Location = new System.Drawing.Point(79, 131);
            this.tbAttatchment.Name = "tbAttatchment";
            this.tbAttatchment.ReadOnly = true;
            this.tbAttatchment.Size = new System.Drawing.Size(166, 20);
            this.tbAttatchment.TabIndex = 5;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Location = new System.Drawing.Point(251, 130);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(121, 23);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cbCategorie
            // 
            this.cbCategorie.CausesValidation = false;
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(79, 157);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(166, 21);
            this.cbCategorie.TabIndex = 7;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(12, 160);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 8;
            this.lblCategorie.Text = "Categorie";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(12, 184);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(110, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Annuleer";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(128, 184);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(244, 23);
            this.btnPost.TabIndex = 10;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btSubCategorie
            // 
            this.btSubCategorie.Location = new System.Drawing.Point(251, 155);
            this.btSubCategorie.Name = "btSubCategorie";
            this.btSubCategorie.Size = new System.Drawing.Size(121, 23);
            this.btSubCategorie.TabIndex = 11;
            this.btSubCategorie.Text = "Nieuwe Sub Categorie";
            this.btSubCategorie.UseVisualStyleBackColor = true;
            // 
            // SMSCreatePost
            // 
            this.AcceptButton = this.btnPost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(384, 214);
            this.Controls.Add(this.btSubCategorie);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tbAttatchment);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SMSCreatePost";
            this.Text = "SMSCreatePost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.TextBox tbAttatchment;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btSubCategorie;
    }
}