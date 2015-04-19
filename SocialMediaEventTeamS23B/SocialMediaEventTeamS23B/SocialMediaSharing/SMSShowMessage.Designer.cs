namespace SocialMediaEventTeamS23B.SMSForms
{
    partial class SMSShowMessage
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.pnlComments = new System.Windows.Forms.Panel();
            this.lblComments = new System.Windows.Forms.Label();
            this.btAddComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titel";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(167, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(205, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Gebruikesnaam";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblContent
            // 
            this.lblContent.Location = new System.Drawing.Point(14, 35);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(358, 41);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Content";
            // 
            // pnlComments
            // 
            this.pnlComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlComments.AutoScroll = true;
            this.pnlComments.Location = new System.Drawing.Point(12, 92);
            this.pnlComments.Name = "pnlComments";
            this.pnlComments.Size = new System.Drawing.Size(360, 328);
            this.pnlComments.TabIndex = 3;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(14, 76);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(49, 13);
            this.lblComments.TabIndex = 4;
            this.lblComments.Text = "Reacties";
            // 
            // btAddComment
            // 
            this.btAddComment.Location = new System.Drawing.Point(12, 426);
            this.btAddComment.Name = "btAddComment";
            this.btAddComment.Size = new System.Drawing.Size(360, 23);
            this.btAddComment.TabIndex = 5;
            this.btAddComment.Text = "Reactie Toevoegen";
            this.btAddComment.UseVisualStyleBackColor = true;
            this.btAddComment.Click += new System.EventHandler(this.btAddComment_Click);
            // 
            // SMSShowMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btAddComment);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.pnlComments);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SMSShowMessage";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Panel pnlComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Button btAddComment;
    }
}