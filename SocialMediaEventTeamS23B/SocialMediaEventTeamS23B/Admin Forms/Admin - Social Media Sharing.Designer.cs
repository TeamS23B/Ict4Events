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
            this.lblFlags = new System.Windows.Forms.Label();
            this.lblLikeFlagRatio = new System.Windows.Forms.Label();
            this.lblTimeSinceFirstFlag = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbAutoFilter = new System.Windows.Forms.CheckBox();
            this.ttAutoFilter = new System.Windows.Forms.ToolTip(this.components);
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.gbAutoFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAllMessages
            // 
            this.lbAllMessages.FormattingEnabled = true;
            this.lbAllMessages.ItemHeight = 16;
            this.lbAllMessages.Location = new System.Drawing.Point(12, 52);
            this.lbAllMessages.Name = "lbAllMessages";
            this.lbAllMessages.Size = new System.Drawing.Size(264, 356);
            this.lbAllMessages.TabIndex = 0;
            // 
            // lblAllMessages
            // 
            this.lblAllMessages.AutoSize = true;
            this.lblAllMessages.Location = new System.Drawing.Point(9, 32);
            this.lblAllMessages.Name = "lblAllMessages";
            this.lblAllMessages.Size = new System.Drawing.Size(95, 17);
            this.lblAllMessages.TabIndex = 1;
            this.lblAllMessages.Text = "Alle Berichten";
            this.lblAllMessages.Click += new System.EventHandler(this.lblAllMessages_Click);
            // 
            // cbMessageVisible
            // 
            this.cbMessageVisible.AutoSize = true;
            this.cbMessageVisible.Location = new System.Drawing.Point(306, 52);
            this.cbMessageVisible.Name = "cbMessageVisible";
            this.cbMessageVisible.Size = new System.Drawing.Size(144, 21);
            this.cbMessageVisible.TabIndex = 2;
            this.cbMessageVisible.Text = "Bericht zichtbaar?";
            this.cbMessageVisible.UseVisualStyleBackColor = true;
            // 
            // nudFlags
            // 
            this.nudFlags.Location = new System.Drawing.Point(153, 62);
            this.nudFlags.Name = "nudFlags";
            this.nudFlags.Size = new System.Drawing.Size(44, 22);
            this.nudFlags.TabIndex = 3;
            // 
            // nudRatio
            // 
            this.nudRatio.Location = new System.Drawing.Point(153, 90);
            this.nudRatio.Name = "nudRatio";
            this.nudRatio.Size = new System.Drawing.Size(44, 22);
            this.nudRatio.TabIndex = 4;
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(153, 118);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(44, 22);
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
            this.gbAutoFilter.Location = new System.Drawing.Point(306, 184);
            this.gbAutoFilter.Name = "gbAutoFilter";
            this.gbAutoFilter.Size = new System.Drawing.Size(247, 156);
            this.gbAutoFilter.TabIndex = 6;
            this.gbAutoFilter.TabStop = false;
            this.gbAutoFilter.Text = "Auto-Filter";
            // 
            // lblFlags
            // 
            this.lblFlags.AutoSize = true;
            this.lblFlags.Location = new System.Drawing.Point(6, 64);
            this.lblFlags.Name = "lblFlags";
            this.lblFlags.Size = new System.Drawing.Size(42, 17);
            this.lblFlags.TabIndex = 6;
            this.lblFlags.Text = "Flags";
            // 
            // lblLikeFlagRatio
            // 
            this.lblLikeFlagRatio.AutoSize = true;
            this.lblLikeFlagRatio.Location = new System.Drawing.Point(6, 92);
            this.lblLikeFlagRatio.Name = "lblLikeFlagRatio";
            this.lblLikeFlagRatio.Size = new System.Drawing.Size(143, 17);
            this.lblLikeFlagRatio.TabIndex = 7;
            this.lblLikeFlagRatio.Text = "Flag / like verhouding";
            // 
            // lblTimeSinceFirstFlag
            // 
            this.lblTimeSinceFirstFlag.AutoSize = true;
            this.lblTimeSinceFirstFlag.Location = new System.Drawing.Point(6, 120);
            this.lblTimeSinceFirstFlag.Name = "lblTimeSinceFirstFlag";
            this.lblTimeSinceFirstFlag.Size = new System.Drawing.Size(139, 17);
            this.lblTimeSinceFirstFlag.TabIndex = 8;
            this.lblTimeSinceFirstFlag.Text = "Tijd sinds eerste flag";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 34);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 29);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(191, 17);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Maak bericht onzichtbaar na:";
            // 
            // cbAutoFilter
            // 
            this.cbAutoFilter.AutoSize = true;
            this.cbAutoFilter.Location = new System.Drawing.Point(307, 157);
            this.cbAutoFilter.Name = "cbAutoFilter";
            this.cbAutoFilter.Size = new System.Drawing.Size(177, 21);
            this.cbAutoFilter.TabIndex = 8;
            this.cbAutoFilter.Text = "Auto-filter geactiveerd?";
            this.cbAutoFilter.UseVisualStyleBackColor = true;
            // 
            // ttAutoFilter
            // 
            this.ttAutoFilter.Tag = "";
            this.ttAutoFilter.ToolTipTitle = "Berichten worden onzichtbaar gemaakt als aan alle voorwaarden wordt voldaan.";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(203, 95);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(20, 17);
            this.lblPercent.TabIndex = 11;
            this.lblPercent.Text = "%";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(203, 123);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(30, 17);
            this.lblMinutes.TabIndex = 12;
            this.lblMinutes.Text = "Min";
            // 
            // Admin___Social_Media_Sharing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 460);
            this.Controls.Add(this.cbAutoFilter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbAutoFilter);
            this.Controls.Add(this.cbMessageVisible);
            this.Controls.Add(this.lblAllMessages);
            this.Controls.Add(this.lbAllMessages);
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