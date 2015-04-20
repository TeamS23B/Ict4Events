namespace SocialMediaEventTeamS23B
{
    partial class ReservationLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationLocation));
            this.lblReservationLocationDetails = new System.Windows.Forms.Label();
            this.lblReservationLocationBungalow = new System.Windows.Forms.Label();
            this.btnReservationLocationPrevious = new System.Windows.Forms.Button();
            this.btnReservationLocationDivideGroup = new System.Windows.Forms.Button();
            this.btnReservationLocationNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReservationLocationDetails
            // 
            this.lblReservationLocationDetails.AutoSize = true;
            this.lblReservationLocationDetails.Location = new System.Drawing.Point(1496, 24);
            this.lblReservationLocationDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservationLocationDetails.Name = "lblReservationLocationDetails";
            this.lblReservationLocationDetails.Size = new System.Drawing.Size(55, 17);
            this.lblReservationLocationDetails.TabIndex = 1;
            this.lblReservationLocationDetails.Text = "Details:";
            // 
            // lblReservationLocationBungalow
            // 
            this.lblReservationLocationBungalow.AutoSize = true;
            this.lblReservationLocationBungalow.Location = new System.Drawing.Point(1496, 46);
            this.lblReservationLocationBungalow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservationLocationBungalow.Name = "lblReservationLocationBungalow";
            this.lblReservationLocationBungalow.Size = new System.Drawing.Size(154, 17);
            this.lblReservationLocationBungalow.TabIndex = 2;
            this.lblReservationLocationBungalow.Text = "Bungalow - 8 personen";
            // 
            // btnReservationLocationPrevious
            // 
            this.btnReservationLocationPrevious.Location = new System.Drawing.Point(1499, 118);
            this.btnReservationLocationPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservationLocationPrevious.Name = "btnReservationLocationPrevious";
            this.btnReservationLocationPrevious.Size = new System.Drawing.Size(100, 28);
            this.btnReservationLocationPrevious.TabIndex = 3;
            this.btnReservationLocationPrevious.Text = "Stap terug";
            this.btnReservationLocationPrevious.UseVisualStyleBackColor = true;
            this.btnReservationLocationPrevious.Click += new System.EventHandler(this.btnReservationLocationPrevious_Click);
            // 
            // btnReservationLocationDivideGroup
            // 
            this.btnReservationLocationDivideGroup.Location = new System.Drawing.Point(1496, 82);
            this.btnReservationLocationDivideGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservationLocationDivideGroup.Name = "btnReservationLocationDivideGroup";
            this.btnReservationLocationDivideGroup.Size = new System.Drawing.Size(121, 28);
            this.btnReservationLocationDivideGroup.TabIndex = 4;
            this.btnReservationLocationDivideGroup.Text = "Deel groep in";
            this.btnReservationLocationDivideGroup.UseVisualStyleBackColor = true;
            this.btnReservationLocationDivideGroup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReservationLocationNext
            // 
            this.btnReservationLocationNext.Location = new System.Drawing.Point(1607, 118);
            this.btnReservationLocationNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReservationLocationNext.Name = "btnReservationLocationNext";
            this.btnReservationLocationNext.Size = new System.Drawing.Size(100, 28);
            this.btnReservationLocationNext.TabIndex = 5;
            this.btnReservationLocationNext.Text = "Volgende stap";
            this.btnReservationLocationNext.UseVisualStyleBackColor = true;
            this.btnReservationLocationNext.Click += new System.EventHandler(this.btnReservationLocationNext_Click);
            // 
            // ReservationLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1715, 1045);
            this.Controls.Add(this.btnReservationLocationNext);
            this.Controls.Add(this.btnReservationLocationDivideGroup);
            this.Controls.Add(this.btnReservationLocationPrevious);
            this.Controls.Add(this.lblReservationLocationBungalow);
            this.Controls.Add(this.lblReservationLocationDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReservationLocation";
            this.Text = "ReservationLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReservationLocationDetails;
        private System.Windows.Forms.Label lblReservationLocationBungalow;
        private System.Windows.Forms.Button btnReservationLocationPrevious;
        private System.Windows.Forms.Button btnReservationLocationDivideGroup;
        private System.Windows.Forms.Button btnReservationLocationNext;
    }
}