namespace SocialMediaEventTeamS23B
{
    partial class frmLogin
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAccesControl = new System.Windows.Forms.Button();
            this.btnSocialMediaSharing = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnReserving = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(275, 169);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(150, 20);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Text = "JimS";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(275, 208);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(150, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "aapje";
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(320, 153);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(322, 192);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(275, 234);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(61, 23);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Location = new System.Drawing.Point(12, 9);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(102, 13);
            this.lblLoggedIn.TabIndex = 5;
            this.lblLoggedIn.Text = "U bent niet ingelogd";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(12, 289);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(120, 60);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Administration";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAccesControl
            // 
            this.btnAccesControl.Location = new System.Drawing.Point(138, 289);
            this.btnAccesControl.Name = "btnAccesControl";
            this.btnAccesControl.Size = new System.Drawing.Size(120, 60);
            this.btnAccesControl.TabIndex = 7;
            this.btnAccesControl.Text = "Toegangs Controlle";
            this.btnAccesControl.UseVisualStyleBackColor = true;
            this.btnAccesControl.Visible = false;
            this.btnAccesControl.Click += new System.EventHandler(this.btnAccesControl_Click_1);
            // 
            // btnSocialMediaSharing
            // 
            this.btnSocialMediaSharing.Location = new System.Drawing.Point(264, 289);
            this.btnSocialMediaSharing.Name = "btnSocialMediaSharing";
            this.btnSocialMediaSharing.Size = new System.Drawing.Size(156, 60);
            this.btnSocialMediaSharing.TabIndex = 8;
            this.btnSocialMediaSharing.Text = "Social Media Sharing";
            this.btnSocialMediaSharing.UseVisualStyleBackColor = true;
            this.btnSocialMediaSharing.Visible = false;
            this.btnSocialMediaSharing.Click += new System.EventHandler(this.btnSocialMediaSharing_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(426, 289);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(120, 60);
            this.btnMaterial.TabIndex = 9;
            this.btnMaterial.Text = "Materiaal uitleen";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Visible = false;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnReserving
            // 
            this.btnReserving.Location = new System.Drawing.Point(552, 289);
            this.btnReserving.Name = "btnReserving";
            this.btnReserving.Size = new System.Drawing.Size(120, 60);
            this.btnReserving.TabIndex = 10;
            this.btnReserving.Text = "Reservering";
            this.btnReserving.UseVisualStyleBackColor = true;
            this.btnReserving.Visible = false;
            this.btnReserving.Click += new System.EventHandler(this.btnReserving_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(364, 234);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(61, 23);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Uitloggen";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnReserving);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnSocialMediaSharing);
            this.Controls.Add(this.btnAccesControl);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Social Media Event - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnAccesControl;
        private System.Windows.Forms.Button btnSocialMediaSharing;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnReserving;
        private System.Windows.Forms.Button btnLogOut;
    }
}