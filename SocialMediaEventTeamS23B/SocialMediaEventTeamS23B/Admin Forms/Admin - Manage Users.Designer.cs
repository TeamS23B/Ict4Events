﻿namespace SocialMediaEventTeamS23B.Beheer_Forms
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
            this.lbVisitors = new System.Windows.Forms.ListBox();
            this.gbMessages = new System.Windows.Forms.GroupBox();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.gbGroupLeader = new System.Windows.Forms.GroupBox();
            this.lblGroupLeaderPaid = new System.Windows.Forms.Label();
            this.lblGroupLeader = new System.Windows.Forms.Label();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.lblMaterials = new System.Windows.Forms.Label();
            this.cbMessageVisible = new System.Windows.Forms.CheckBox();
            this.cbUserBlocked = new System.Windows.Forms.CheckBox();
            this.lbMaterials = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbUsers.SuspendLayout();
            this.gbMessages.SuspendLayout();
            this.gbGroupLeader.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.lbVisitors);
            this.gbUsers.Location = new System.Drawing.Point(12, 11);
            this.gbUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUsers.Size = new System.Drawing.Size(296, 373);
            this.gbUsers.TabIndex = 4;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Gebruikers";
            // 
            // lbVisitors
            // 
            this.lbVisitors.FormattingEnabled = true;
            this.lbVisitors.ItemHeight = 16;
            this.lbVisitors.Location = new System.Drawing.Point(5, 21);
            this.lbVisitors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbVisitors.Name = "lbVisitors";
            this.lbVisitors.Size = new System.Drawing.Size(284, 340);
            this.lbVisitors.TabIndex = 1;
            this.lbVisitors.SelectedIndexChanged += new System.EventHandler(this.lbVisitors_SelectedIndexChanged);
            // 
            // gbMessages
            // 
            this.gbMessages.Controls.Add(this.lbMessages);
            this.gbMessages.Location = new System.Drawing.Point(315, 12);
            this.gbMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMessages.Name = "gbMessages";
            this.gbMessages.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMessages.Size = new System.Drawing.Size(296, 373);
            this.gbMessages.TabIndex = 5;
            this.gbMessages.TabStop = false;
            this.gbMessages.Text = "Berichten van gebruiker";
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 16;
            this.lbMessages.Location = new System.Drawing.Point(5, 20);
            this.lbMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(284, 340);
            this.lbMessages.TabIndex = 0;
            this.lbMessages.SelectedIndexChanged += new System.EventHandler(this.lbMessages_SelectedIndexChanged);
            // 
            // gbGroupLeader
            // 
            this.gbGroupLeader.Controls.Add(this.lblGroupLeaderPaid);
            this.gbGroupLeader.Controls.Add(this.lblGroupLeader);
            this.gbGroupLeader.Location = new System.Drawing.Point(315, 391);
            this.gbGroupLeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGroupLeader.Name = "gbGroupLeader";
            this.gbGroupLeader.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGroupLeader.Size = new System.Drawing.Size(296, 78);
            this.gbGroupLeader.TabIndex = 6;
            this.gbGroupLeader.TabStop = false;
            this.gbGroupLeader.Text = "Groepsleider";
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
            // lblGroupLeader
            // 
            this.lblGroupLeader.AutoSize = true;
            this.lblGroupLeader.Location = new System.Drawing.Point(7, 22);
            this.lblGroupLeader.Name = "lblGroupLeader";
            this.lblGroupLeader.Size = new System.Drawing.Size(127, 17);
            this.lblGroupLeader.TabIndex = 0;
            this.lblGroupLeader.Text = "De groepsleider is:";
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.lblMaterials);
            this.gbUserInfo.Controls.Add(this.cbMessageVisible);
            this.gbUserInfo.Controls.Add(this.cbUserBlocked);
            this.gbUserInfo.Controls.Add(this.lbMaterials);
            this.gbUserInfo.Location = new System.Drawing.Point(616, 12);
            this.gbUserInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUserInfo.Size = new System.Drawing.Size(212, 372);
            this.gbUserInfo.TabIndex = 9;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "Gebruikers info";
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
            // cbMessageVisible
            // 
            this.cbMessageVisible.AutoSize = true;
            this.cbMessageVisible.Enabled = false;
            this.cbMessageVisible.Location = new System.Drawing.Point(20, 48);
            this.cbMessageVisible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMessageVisible.Name = "cbMessageVisible";
            this.cbMessageVisible.Size = new System.Drawing.Size(152, 21);
            this.cbMessageVisible.TabIndex = 11;
            this.cbMessageVisible.Text = "Bericht onzichtbaar";
            this.cbMessageVisible.UseVisualStyleBackColor = true;
            this.cbMessageVisible.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbUserBlocked
            // 
            this.cbUserBlocked.AutoSize = true;
            this.cbUserBlocked.Enabled = false;
            this.cbUserBlocked.Location = new System.Drawing.Point(20, 21);
            this.cbUserBlocked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUserBlocked.Name = "cbUserBlocked";
            this.cbUserBlocked.Size = new System.Drawing.Size(175, 21);
            this.cbUserBlocked.TabIndex = 10;
            this.cbUserBlocked.Text = "Gebruiker geblokkeerd";
            this.cbUserBlocked.UseVisualStyleBackColor = true;
            this.cbUserBlocked.CheckedChanged += new System.EventHandler(this.cbUserBlocked_CheckedChanged);
            // 
            // lbMaterials
            // 
            this.lbMaterials.FormattingEnabled = true;
            this.lbMaterials.ItemHeight = 16;
            this.lbMaterials.Location = new System.Drawing.Point(20, 112);
            this.lbMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMaterials.Name = "lbMaterials";
            this.lbMaterials.Size = new System.Drawing.Size(173, 244);
            this.lbMaterials.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(28, 407);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(164, 62);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Beheer___Gebruikers_Beheren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 494);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.gbGroupLeader);
            this.Controls.Add(this.gbMessages);
            this.Controls.Add(this.gbUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Beheer___Gebruikers_Beheren";
            this.Text = "Beheer___Gebruikers_Beheren";
            this.Click += new System.EventHandler(this.Beheer___Gebruikers_Beheren_Click);
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
        private System.Windows.Forms.ListBox lbVisitors;
    }
}