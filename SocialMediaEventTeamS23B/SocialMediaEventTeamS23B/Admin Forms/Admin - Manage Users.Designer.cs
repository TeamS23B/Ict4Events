namespace SocialMediaEventTeamS23B.Beheer_Forms
{
    partial class Beheer___Gebruikers_Beheren
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
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.gbMessages = new System.Windows.Forms.GroupBox();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.gbGroupLeader = new System.Windows.Forms.GroupBox();
            this.lblGroupLeader = new System.Windows.Forms.Label();
            this.lblGroupLeaderPaid = new System.Windows.Forms.Label();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.cbMessageVisible = new System.Windows.Forms.CheckBox();
            this.cbUserBlocked = new System.Windows.Forms.CheckBox();
            this.lbMaterials = new System.Windows.Forms.ListBox();
            this.lblMaterials = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLikes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFlags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbUsers.SuspendLayout();
            this.gbMessages.SuspendLayout();
            this.gbGroupLeader.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.lvUsers);
            this.gbUsers.Location = new System.Drawing.Point(12, 11);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(296, 373);
            this.gbUsers.TabIndex = 4;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Gebruikers";
            // 
            // gbMessages
            // 
            this.gbMessages.Controls.Add(this.lbMessages);
            this.gbMessages.Location = new System.Drawing.Point(314, 12);
            this.gbMessages.Name = "gbMessages";
            this.gbMessages.Size = new System.Drawing.Size(296, 373);
            this.gbMessages.TabIndex = 5;
            this.gbMessages.TabStop = false;
            this.gbMessages.Text = "Berichten van gebruiker";
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 16;
            this.lbMessages.Location = new System.Drawing.Point(6, 20);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(284, 340);
            this.lbMessages.TabIndex = 0;
            // 
            // gbGroupLeader
            // 
            this.gbGroupLeader.Controls.Add(this.lblGroupLeaderPaid);
            this.gbGroupLeader.Controls.Add(this.lblGroupLeader);
            this.gbGroupLeader.Location = new System.Drawing.Point(314, 392);
            this.gbGroupLeader.Name = "gbGroupLeader";
            this.gbGroupLeader.Size = new System.Drawing.Size(296, 77);
            this.gbGroupLeader.TabIndex = 6;
            this.gbGroupLeader.TabStop = false;
            this.gbGroupLeader.Text = "Groepsleider";
            // 
            // lblGroupLeader
            // 
            this.lblGroupLeader.AutoSize = true;
            this.lblGroupLeader.Location = new System.Drawing.Point(7, 22);
            this.lblGroupLeader.Name = "lblGroupLeader";
            this.lblGroupLeader.Size = new System.Drawing.Size(127, 17);
            this.lblGroupLeader.TabIndex = 0;
            this.lblGroupLeader.Text = "De groepsleider is:";
            // 
            // lblGroupLeaderPaid
            // 
            this.lblGroupLeaderPaid.AutoSize = true;
            this.lblGroupLeaderPaid.Location = new System.Drawing.Point(7, 48);
            this.lblGroupLeaderPaid.Name = "lblGroupLeaderPaid";
            this.lblGroupLeaderPaid.Size = new System.Drawing.Size(60, 17);
            this.lblGroupLeaderPaid.TabIndex = 1;
            this.lblGroupLeaderPaid.Text = "Betaald:";
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.lblMaterials);
            this.gbUserInfo.Controls.Add(this.cbMessageVisible);
            this.gbUserInfo.Controls.Add(this.cbUserBlocked);
            this.gbUserInfo.Controls.Add(this.lbMaterials);
            this.gbUserInfo.Location = new System.Drawing.Point(616, 12);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(212, 372);
            this.gbUserInfo.TabIndex = 9;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "Gebruikers info";
            // 
            // cbMessageVisible
            // 
            this.cbMessageVisible.AutoSize = true;
            this.cbMessageVisible.Enabled = false;
            this.cbMessageVisible.Location = new System.Drawing.Point(20, 48);
            this.cbMessageVisible.Name = "cbMessageVisible";
            this.cbMessageVisible.Size = new System.Drawing.Size(144, 21);
            this.cbMessageVisible.TabIndex = 11;
            this.cbMessageVisible.Text = "Bericht zichtbaar?";
            this.cbMessageVisible.UseVisualStyleBackColor = true;
            this.cbMessageVisible.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbUserBlocked
            // 
            this.cbUserBlocked.AutoSize = true;
            this.cbUserBlocked.Enabled = false;
            this.cbUserBlocked.Location = new System.Drawing.Point(20, 21);
            this.cbUserBlocked.Name = "cbUserBlocked";
            this.cbUserBlocked.Size = new System.Drawing.Size(183, 21);
            this.cbUserBlocked.TabIndex = 10;
            this.cbUserBlocked.Text = "Gebruiker geblokkeerd?";
            this.cbUserBlocked.UseVisualStyleBackColor = true;
            // 
            // lbMaterials
            // 
            this.lbMaterials.FormattingEnabled = true;
            this.lbMaterials.ItemHeight = 16;
            this.lbMaterials.Location = new System.Drawing.Point(20, 112);
            this.lbMaterials.Name = "lbMaterials";
            this.lbMaterials.Size = new System.Drawing.Size(173, 244);
            this.lbMaterials.TabIndex = 9;
            // 
            // lblMaterials
            // 
            this.lblMaterials.AutoSize = true;
            this.lblMaterials.Location = new System.Drawing.Point(20, 89);
            this.lblMaterials.Name = "lblMaterials";
            this.lblMaterials.Size = new System.Drawing.Size(126, 17);
            this.lblMaterials.TabIndex = 12;
            this.lblMaterials.Text = "Gehuurd materiaal";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(28, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(164, 62);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsername,
            this.chLikes,
            this.chFlags});
            this.lvUsers.Location = new System.Drawing.Point(16, 18);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(263, 339);
            this.lvUsers.TabIndex = 11;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // chUsername
            // 
            this.chUsername.Text = "Gebruikersnaam";
            this.chUsername.Width = 153;
            // 
            // chLikes
            // 
            this.chLikes.Text = "Likes";
            this.chLikes.Width = 58;
            // 
            // chFlags
            // 
            this.chFlags.Text = "Flags";
            this.chFlags.Width = 48;
            // 
            // Beheer___Gebruikers_Beheren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 493);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.gbGroupLeader);
            this.Controls.Add(this.gbMessages);
            this.Controls.Add(this.gbUsers);
            this.Name = "Beheer___Gebruikers_Beheren";
            this.Text = "Beheer___Gebruikers_Beheren";
            this.gbUsers.ResumeLayout(false);
            this.gbMessages.ResumeLayout(false);
            this.gbGroupLeader.ResumeLayout(false);
            this.gbGroupLeader.PerformLayout();
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.GroupBox gbMessages;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.GroupBox gbGroupLeader;
        private System.Windows.Forms.Label lblGroupLeaderPaid;
        private System.Windows.Forms.Label lblGroupLeader;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.CheckBox cbMessageVisible;
        private System.Windows.Forms.CheckBox cbUserBlocked;
        private System.Windows.Forms.ListBox lbMaterials;
        private System.Windows.Forms.Label lblMaterials;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chLikes;
        private System.Windows.Forms.ColumnHeader chFlags;
    }
}