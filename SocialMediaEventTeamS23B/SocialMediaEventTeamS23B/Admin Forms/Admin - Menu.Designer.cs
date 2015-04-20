namespace SocialMediaEventTeamS23B.Admin_Forms
{
    partial class Admin___Menu
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
            this.btnAdminAddMaterial = new System.Windows.Forms.Button();
            this.btnAdminCreateEvent = new System.Windows.Forms.Button();
            this.btnAdminManageUsers = new System.Windows.Forms.Button();
            this.btnAdminSocialMediaSharing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminAddMaterial
            // 
            this.btnAdminAddMaterial.Location = new System.Drawing.Point(16, 15);
            this.btnAdminAddMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminAddMaterial.Name = "btnAdminAddMaterial";
            this.btnAdminAddMaterial.Size = new System.Drawing.Size(173, 96);
            this.btnAdminAddMaterial.TabIndex = 0;
            this.btnAdminAddMaterial.Text = "Materiaal Toevoegen";
            this.btnAdminAddMaterial.UseVisualStyleBackColor = true;
            this.btnAdminAddMaterial.Click += new System.EventHandler(this.btnAdminAddMaterial_Click);
            // 
            // btnAdminCreateEvent
            // 
            this.btnAdminCreateEvent.Location = new System.Drawing.Point(197, 15);
            this.btnAdminCreateEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminCreateEvent.Name = "btnAdminCreateEvent";
            this.btnAdminCreateEvent.Size = new System.Drawing.Size(173, 96);
            this.btnAdminCreateEvent.TabIndex = 1;
            this.btnAdminCreateEvent.Text = "Event Aanmaken";
            this.btnAdminCreateEvent.UseVisualStyleBackColor = true;
            this.btnAdminCreateEvent.Click += new System.EventHandler(this.btnAdminCreateEvent_Click);
            // 
            // btnAdminManageUsers
            // 
            this.btnAdminManageUsers.Location = new System.Drawing.Point(16, 118);
            this.btnAdminManageUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminManageUsers.Name = "btnAdminManageUsers";
            this.btnAdminManageUsers.Size = new System.Drawing.Size(173, 96);
            this.btnAdminManageUsers.TabIndex = 2;
            this.btnAdminManageUsers.Text = "Gebruikers Beheren";
            this.btnAdminManageUsers.UseVisualStyleBackColor = true;
            this.btnAdminManageUsers.Click += new System.EventHandler(this.btnAdminManageUsers_Click);
            // 
            // btnAdminSocialMediaSharing
            // 
            this.btnAdminSocialMediaSharing.Location = new System.Drawing.Point(197, 118);
            this.btnAdminSocialMediaSharing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminSocialMediaSharing.Name = "btnAdminSocialMediaSharing";
            this.btnAdminSocialMediaSharing.Size = new System.Drawing.Size(173, 96);
            this.btnAdminSocialMediaSharing.TabIndex = 3;
            this.btnAdminSocialMediaSharing.Text = "Social Media Sharing";
            this.btnAdminSocialMediaSharing.UseVisualStyleBackColor = true;
            this.btnAdminSocialMediaSharing.Click += new System.EventHandler(this.btnAdminSocialMediaSharing_Click);
            // 
            // Admin___Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 229);
            this.Controls.Add(this.btnAdminSocialMediaSharing);
            this.Controls.Add(this.btnAdminManageUsers);
            this.Controls.Add(this.btnAdminCreateEvent);
            this.Controls.Add(this.btnAdminAddMaterial);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin___Menu";
            this.Text = "Admin___Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminAddMaterial;
        private System.Windows.Forms.Button btnAdminCreateEvent;
        private System.Windows.Forms.Button btnAdminManageUsers;
        private System.Windows.Forms.Button btnAdminSocialMediaSharing;
    }
}