namespace SocialMediaEventTeamS23B.Beheer_Forms
{
    partial class Admin___Main_Menu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnManageMaterial = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageEvent = new System.Windows.Forms.Button();
            this.btnManageSocialMedia = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 22);
            this.textBox2.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(105, 127);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManageMaterial
            // 
            this.btnManageMaterial.Location = new System.Drawing.Point(12, 166);
            this.btnManageMaterial.Name = "btnManageMaterial";
            this.btnManageMaterial.Size = new System.Drawing.Size(129, 55);
            this.btnManageMaterial.TabIndex = 3;
            this.btnManageMaterial.Text = "Materiaal Beheer";
            this.btnManageMaterial.UseVisualStyleBackColor = true;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(12, 227);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(129, 47);
            this.btnManageUsers.TabIndex = 4;
            this.btnManageUsers.Text = "Gebruiker Beheer";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnManageEvent
            // 
            this.btnManageEvent.Location = new System.Drawing.Point(147, 166);
            this.btnManageEvent.Name = "btnManageEvent";
            this.btnManageEvent.Size = new System.Drawing.Size(123, 55);
            this.btnManageEvent.TabIndex = 5;
            this.btnManageEvent.Text = "Event Aanmaken";
            this.btnManageEvent.UseVisualStyleBackColor = true;
            // 
            // btnManageSocialMedia
            // 
            this.btnManageSocialMedia.Location = new System.Drawing.Point(147, 227);
            this.btnManageSocialMedia.Name = "btnManageSocialMedia";
            this.btnManageSocialMedia.Size = new System.Drawing.Size(123, 47);
            this.btnManageSocialMedia.TabIndex = 6;
            this.btnManageSocialMedia.Text = "Social Media Event Beheer";
            this.btnManageSocialMedia.UseVisualStyleBackColor = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(83, 14);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(117, 17);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Gebruikersnaam:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(97, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 17);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Wachtwoord:";
            // 
            // Admin___Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 286);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnManageSocialMedia);
            this.Controls.Add(this.btnManageEvent);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageMaterial);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Admin___Main_Menu";
            this.Text = "Admin___Main_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnManageMaterial;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageEvent;
        private System.Windows.Forms.Button btnManageSocialMedia;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
    }
}