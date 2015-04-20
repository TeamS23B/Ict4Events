namespace SocialMediaEventTeamS23B.SMSForms
{
    partial class SMSMesageMainMedia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnFlag = new System.Windows.Forms.Button();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblFlags = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Location = new System.Drawing.Point(151, 15);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(207, 18);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(12, 33);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(57, 17);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "Content";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(4, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLike
            // 
            this.btnLike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLike.Location = new System.Drawing.Point(4, 293);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 36);
            this.btnLike.TabIndex = 7;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFlag.Location = new System.Drawing.Point(85, 293);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(75, 36);
            this.btnFlag.TabIndex = 8;
            this.btnFlag.Text = "Flag";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikes.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblLikes.Location = new System.Drawing.Point(166, 298);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(21, 24);
            this.lblLikes.TabIndex = 9;
            this.lblLikes.Text = "0";
            // 
            // lblFlags
            // 
            this.lblFlags.AutoSize = true;
            this.lblFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlags.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFlags.Location = new System.Drawing.Point(267, 298);
            this.lblFlags.Name = "lblFlags";
            this.lblFlags.Size = new System.Drawing.Size(21, 24);
            this.lblFlags.TabIndex = 10;
            this.lblFlags.Text = "0";
            // 
            // SMSMesageMainMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblFlags);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SMSMesageMainMedia";
            this.Size = new System.Drawing.Size(368, 332);
            this.DoubleClick += new System.EventHandler(this.SMSMessageMainMedia_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblFlags;
    }
}
