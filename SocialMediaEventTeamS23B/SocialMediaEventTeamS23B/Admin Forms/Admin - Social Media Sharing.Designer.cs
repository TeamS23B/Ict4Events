namespace SocialMediaEventTeamS23B.Admin_Forms
{
    partial class Admin___Social_Media_Sharing
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
            this.components = new System.ComponentModel.Container();
            this.lbAllMessages = new System.Windows.Forms.ListBox();
            this.lblAllMessages = new System.Windows.Forms.Label();
            this.cbMessageVisible = new System.Windows.Forms.CheckBox();
            this.nudFlags = new System.Windows.Forms.NumericUpDown();
            this.nudRatio = new System.Windows.Forms.NumericUpDown();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.gbAutoFilter = new System.Windows.Forms.GroupBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTimeSinceFirstFlag = new System.Windows.Forms.Label();
            this.lblLikeFlagRatio = new System.Windows.Forms.Label();
            this.lblFlags = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbAutoFilter = new System.Windows.Forms.CheckBox();
            this.ttAutoFilter = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.gbAutoFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAllMessages
            // 
            this.lbAllMessages.FormattingEnabled = true;
            this.lbAllMessages.Location = new System.Drawing.Point(9, 42);
            this.lbAllMessages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbAllMessages.Name = "lbAllMessages";
            this.lbAllMessages.Size = new System.Drawing.Size(199, 290);
            this.lbAllMessages.TabIndex = 0;
            // 
            // lblAllMessages
            // 
            this.lblAllMessages.AutoSize = true;
            this.lblAllMessages.Location = new System.Drawing.Point(7, 26);
            this.lblAllMessages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllMessages.Name = "lblAllMessages";
            this.lblAllMessages.Size = new System.Drawing.Size(72, 13);
            this.lblAllMessages.TabIndex = 1;
            this.lblAllMessages.Text = "Alle Berichten";
            this.lblAllMessages.Click += new System.EventHandler(this.lblAllMessages_Click);
            // 
            // cbMessageVisible
            // 
            this.cbMessageVisible.AutoSize = true;
            this.cbMessageVisible.Location = new System.Drawing.Point(230, 42);
            this.cbMessageVisible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMessageVisible.Name = "cbMessageVisible";
            this.cbMessageVisible.Size = new System.Drawing.Size(111, 17);
            this.cbMessageVisible.TabIndex = 2;
            this.cbMessageVisible.Text = "Bericht zichtbaar?";
            this.cbMessageVisible.UseVisualStyleBackColor = true;
            // 
            // nudFlags
            // 
            this.nudFlags.Location = new System.Drawing.Point(115, 50);
            this.nudFlags.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudFlags.Name = "nudFlags";
            this.nudFlags.Size = new System.Drawing.Size(33, 20);
            this.nudFlags.TabIndex = 3;
            // 
            // nudRatio
            // 
            this.nudRatio.Location = new System.Drawing.Point(115, 73);
            this.nudRatio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudRatio.Name = "nudRatio";
            this.nudRatio.Size = new System.Drawing.Size(33, 20);
            this.nudRatio.TabIndex = 4;
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(115, 96);
            this.nudTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(33, 20);
            this.nudTime.TabIndex = 5;
            // 
            // gbAutoFilter
            // 
            this.gbAutoFilter.Controls.Add(this.lblMinutes);
            this.gbAutoFilter.Controls.Add(this.lblPercent);
            this.gbAutoFilter.Controls.Add(this.lblDescription);
            this.gbAutoFilter.Controls.Add(this.lblTimeSinceFirstFlag);
            this.gbAutoFilter.Controls.Add(this.lblLikeFlagRatio);
            this.gbAutoFilter.Controls.Add(this.lblFlags);
            this.gbAutoFilter.Controls.Add(this.nudFlags);
            this.gbAutoFilter.Controls.Add(this.nudTime);
            this.gbAutoFilter.Controls.Add(this.nudRatio);
            this.gbAutoFilter.Location = new System.Drawing.Point(230, 150);
            this.gbAutoFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAutoFilter.Name = "gbAutoFilter";
            this.gbAutoFilter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAutoFilter.Size = new System.Drawing.Size(185, 127);
            this.gbAutoFilter.TabIndex = 6;
            this.gbAutoFilter.TabStop = false;
            this.gbAutoFilter.Text = "Auto-Filter";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(152, 100);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(24, 13);
            this.lblMinutes.TabIndex = 12;
            this.lblMinutes.Text = "Min";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(152, 77);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(15, 13);
            this.lblPercent.TabIndex = 11;
            this.lblPercent.Text = "%";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(4, 24);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(145, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Maak bericht onzichtbaar na:";
            // 
            // lblTimeSinceFirstFlag
            // 
            this.lblTimeSinceFirstFlag.AutoSize = true;
            this.lblTimeSinceFirstFlag.Location = new System.Drawing.Point(4, 98);
            this.lblTimeSinceFirstFlag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeSinceFirstFlag.Name = "lblTimeSinceFirstFlag";
            this.lblTimeSinceFirstFlag.Size = new System.Drawing.Size(103, 13);
            this.lblTimeSinceFirstFlag.TabIndex = 8;
            this.lblTimeSinceFirstFlag.Text = "Tijd sinds eerste flag";
            // 
            // lblLikeFlagRatio
            // 
            this.lblLikeFlagRatio.AutoSize = true;
            this.lblLikeFlagRatio.Location = new System.Drawing.Point(4, 75);
            this.lblLikeFlagRatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLikeFlagRatio.Name = "lblLikeFlagRatio";
            this.lblLikeFlagRatio.Size = new System.Drawing.Size(110, 13);
            this.lblLikeFlagRatio.TabIndex = 7;
            this.lblLikeFlagRatio.Text = "Flag / like verhouding";
            // 
            // lblFlags
            // 
            this.lblFlags.AutoSize = true;
            this.lblFlags.Location = new System.Drawing.Point(4, 52);
            this.lblFlags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlags.Name = "lblFlags";
            this.lblFlags.Size = new System.Drawing.Size(32, 13);
            this.lblFlags.TabIndex = 6;
            this.lblFlags.Text = "Flags";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 336);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 28);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbAutoFilter
            // 
            this.cbAutoFilter.AutoSize = true;
            this.cbAutoFilter.Location = new System.Drawing.Point(230, 128);
            this.cbAutoFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAutoFilter.Name = "cbAutoFilter";
            this.cbAutoFilter.Size = new System.Drawing.Size(135, 17);
            this.cbAutoFilter.TabIndex = 8;
            this.cbAutoFilter.Text = "Auto-filter geactiveerd?";
            this.cbAutoFilter.UseVisualStyleBackColor = true;
            // 
            // ttAutoFilter
            // 
            this.ttAutoFilter.Tag = "";
            this.ttAutoFilter.ToolTipTitle = "Berichten worden onzichtbaar gemaakt als aan alle voorwaarden wordt voldaan.";
            // 
            // Admin___Social_Media_Sharing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 374);
            this.Controls.Add(this.cbAutoFilter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbAutoFilter);
            this.Controls.Add(this.cbMessageVisible);
            this.Controls.Add(this.lblAllMessages);
            this.Controls.Add(this.lbAllMessages);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin___Social_Media_Sharing";
            this.Text = "Admin___Social_Media_Sharing";
            ((System.ComponentModel.ISupportInitialize)(this.nudFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.gbAutoFilter.ResumeLayout(false);
            this.gbAutoFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAllMessages;
        private System.Windows.Forms.Label lblAllMessages;
        private System.Windows.Forms.CheckBox cbMessageVisible;
        private System.Windows.Forms.NumericUpDown nudFlags;
        private System.Windows.Forms.NumericUpDown nudRatio;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.GroupBox gbAutoFilter;
        private System.Windows.Forms.Label lblTimeSinceFirstFlag;
        private System.Windows.Forms.Label lblLikeFlagRatio;
        private System.Windows.Forms.Label lblFlags;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cbAutoFilter;
        private System.Windows.Forms.ToolTip ttAutoFilter;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblPercent;
    }
}