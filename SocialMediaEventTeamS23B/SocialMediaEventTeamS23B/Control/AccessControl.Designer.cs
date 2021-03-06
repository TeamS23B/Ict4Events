﻿namespace SocialMediaEventTeamS23B
{
    partial class AccessControl
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
            this.lblRFIDTop = new System.Windows.Forms.Label();
            this.lblRFID = new System.Windows.Forms.Label();
            this.lblPayedTop = new System.Windows.Forms.Label();
            this.lblPayed = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btReattatch = new System.Windows.Forms.Button();
            this.delayClean = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblRFIDTop
            // 
            this.lblRFIDTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFIDTop.Location = new System.Drawing.Point(12, 61);
            this.lblRFIDTop.Name = "lblRFIDTop";
            this.lblRFIDTop.Size = new System.Drawing.Size(660, 23);
            this.lblRFIDTop.TabIndex = 0;
            this.lblRFIDTop.Text = "RFID";
            this.lblRFIDTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRFID
            // 
            this.lblRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFID.Location = new System.Drawing.Point(12, 87);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(660, 54);
            this.lblRFID.TabIndex = 1;
            this.lblRFID.Text = "00000000";
            this.lblRFID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPayedTop
            // 
            this.lblPayedTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayedTop.Location = new System.Drawing.Point(12, 182);
            this.lblPayedTop.Name = "lblPayedTop";
            this.lblPayedTop.Size = new System.Drawing.Size(660, 23);
            this.lblPayedTop.TabIndex = 2;
            this.lblPayedTop.Text = "Betaald";
            this.lblPayedTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPayed
            // 
            this.lblPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPayed.Location = new System.Drawing.Point(12, 208);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(660, 55);
            this.lblPayed.TabIndex = 3;
            this.lblPayed.Text = "-";
            this.lblPayed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(12, 326);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 26);
            this.lblError.TabIndex = 4;
            // 
            // btReattatch
            // 
            this.btReattatch.Location = new System.Drawing.Point(12, 12);
            this.btReattatch.Name = "btReattatch";
            this.btReattatch.Size = new System.Drawing.Size(75, 23);
            this.btReattatch.TabIndex = 5;
            this.btReattatch.Text = "Reattatch";
            this.btReattatch.UseVisualStyleBackColor = true;
            this.btReattatch.Visible = false;
            this.btReattatch.Click += new System.EventHandler(this.btReattatch_Click);
            // 
            // delayClean
            // 
            this.delayClean.Interval = 2000;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 108);
            this.listBox1.TabIndex = 7;
            // 
            // AccessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btReattatch);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblPayed);
            this.Controls.Add(this.lblPayedTop);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.lblRFIDTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessControl";
            this.Text = "Toegangs controlle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccessControl_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRFIDTop;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label lblPayedTop;
        private System.Windows.Forms.Label lblPayed;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btReattatch;
        private System.Windows.Forms.Timer delayClean;
        private System.Windows.Forms.ListBox listBox1;
    }
}