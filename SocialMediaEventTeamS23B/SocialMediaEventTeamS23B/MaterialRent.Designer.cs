namespace SocialMediaEventTeamS23B
{
    partial class MaterialRent
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
            this.lblProductOpVoorraad = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHuurkosten = new System.Windows.Forms.Label();
            this.lblGescandeRfid = new System.Windows.Forms.Label();
            this.lblRfid = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblEinddatumKiezen = new System.Windows.Forms.Label();
            this.dateTimePickerEinddatum = new System.Windows.Forms.DateTimePicker();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductOpVoorraad
            // 
            this.lblProductOpVoorraad.AutoSize = true;
            this.lblProductOpVoorraad.Location = new System.Drawing.Point(31, 51);
            this.lblProductOpVoorraad.Name = "lblProductOpVoorraad";
            this.lblProductOpVoorraad.Size = new System.Drawing.Size(116, 13);
            this.lblProductOpVoorraad.TabIndex = 0;
            this.lblProductOpVoorraad.Text = "Producten op voorraad";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 173);
            this.listBox1.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(34, 288);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "Details";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(34, 338);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // lblHuurkosten
            // 
            this.lblHuurkosten.AutoSize = true;
            this.lblHuurkosten.Location = new System.Drawing.Point(34, 312);
            this.lblHuurkosten.Name = "lblHuurkosten";
            this.lblHuurkosten.Size = new System.Drawing.Size(83, 13);
            this.lblHuurkosten.TabIndex = 4;
            this.lblHuurkosten.Text = "Huurkosten : 20";
            // 
            // lblGescandeRfid
            // 
            this.lblGescandeRfid.AutoSize = true;
            this.lblGescandeRfid.Location = new System.Drawing.Point(321, 50);
            this.lblGescandeRfid.Name = "lblGescandeRfid";
            this.lblGescandeRfid.Size = new System.Drawing.Size(93, 13);
            this.lblGescandeRfid.TabIndex = 5;
            this.lblGescandeRfid.Text = "Gescande RFID : ";
            // 
            // lblRfid
            // 
            this.lblRfid.AutoSize = true;
            this.lblRfid.Location = new System.Drawing.Point(321, 93);
            this.lblRfid.Name = "lblRfid";
            this.lblRfid.Size = new System.Drawing.Size(41, 13);
            this.lblRfid.TabIndex = 6;
            this.lblRfid.Text = "RFID : ";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(321, 131);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(68, 13);
            this.lblNaam.TabIndex = 7;
            this.lblNaam.Text = "Naam :  XXX";
            // 
            // lblEinddatumKiezen
            // 
            this.lblEinddatumKiezen.AutoSize = true;
            this.lblEinddatumKiezen.Location = new System.Drawing.Point(321, 206);
            this.lblEinddatumKiezen.Name = "lblEinddatumKiezen";
            this.lblEinddatumKiezen.Size = new System.Drawing.Size(91, 13);
            this.lblEinddatumKiezen.TabIndex = 8;
            this.lblEinddatumKiezen.Text = "Einddatum kiezen";
            // 
            // dateTimePickerEinddatum
            // 
            this.dateTimePickerEinddatum.Location = new System.Drawing.Point(324, 246);
            this.dateTimePickerEinddatum.Name = "dateTimePickerEinddatum";
            this.dateTimePickerEinddatum.Size = new System.Drawing.Size(173, 20);
            this.dateTimePickerEinddatum.TabIndex = 9;
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Location = new System.Drawing.Point(324, 298);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(75, 23);
            this.btnBevestigen.TabIndex = 10;
            this.btnBevestigen.Text = "Bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            // 
            // MATERIAALVERHUUR_MATERIAALVERHUURcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 425);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.dateTimePickerEinddatum);
            this.Controls.Add(this.lblEinddatumKiezen);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblRfid);
            this.Controls.Add(this.lblGescandeRfid);
            this.Controls.Add(this.lblHuurkosten);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblProductOpVoorraad);
            this.Name = "MATERIAALVERHUUR_MATERIAALVERHUURcs";
            this.Text = "MATERIAALVERHUUR_MATERIAALVERHUURcs";
            this.Load += new System.EventHandler(this.MATERIAALVERHUUR_MATERIAALVERHUURcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductOpVoorraad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHuurkosten;
        private System.Windows.Forms.Label lblGescandeRfid;
        private System.Windows.Forms.Label lblRfid;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblEinddatumKiezen;
        private System.Windows.Forms.DateTimePicker dateTimePickerEinddatum;
        private System.Windows.Forms.Button btnBevestigen;
    }
}