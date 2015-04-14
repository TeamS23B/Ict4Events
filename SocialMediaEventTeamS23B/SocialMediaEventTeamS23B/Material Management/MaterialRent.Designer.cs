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
            this.components = new System.ComponentModel.Container();
            this.lblMaterialRentProductsInStorage = new System.Windows.Forms.Label();
            this.lbMaterialRentProductsInList = new System.Windows.Forms.ListBox();
            this.lblMaterialRentDetails = new System.Windows.Forms.Label();
            this.lblMaterialRentStatus = new System.Windows.Forms.Label();
            this.lblMaterialRentHireCost = new System.Windows.Forms.Label();
            this.lblMaterialRentScannedRfid = new System.Windows.Forms.Label();
            this.lblMaterialRentRfid = new System.Windows.Forms.Label();
            this.lblMaterialRentName = new System.Windows.Forms.Label();
            this.lblMaterialRentChooseEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerMaterialRentEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnMaterialRentConfirm = new System.Windows.Forms.Button();
            this.delayClean = new System.Windows.Forms.Timer(this.components);
            this.btnReattach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaterialRentProductsInStorage
            // 
            this.lblMaterialRentProductsInStorage.AutoSize = true;
            this.lblMaterialRentProductsInStorage.Location = new System.Drawing.Point(31, 51);
            this.lblMaterialRentProductsInStorage.Name = "lblMaterialRentProductsInStorage";
            this.lblMaterialRentProductsInStorage.Size = new System.Drawing.Size(116, 13);
            this.lblMaterialRentProductsInStorage.TabIndex = 0;
            this.lblMaterialRentProductsInStorage.Text = "Producten op voorraad";
            // 
            // lbMaterialRentProductsInList
            // 
            this.lbMaterialRentProductsInList.FormattingEnabled = true;
            this.lbMaterialRentProductsInList.Location = new System.Drawing.Point(34, 93);
            this.lbMaterialRentProductsInList.Name = "lbMaterialRentProductsInList";
            this.lbMaterialRentProductsInList.Size = new System.Drawing.Size(134, 173);
            this.lbMaterialRentProductsInList.TabIndex = 1;
            this.lbMaterialRentProductsInList.SelectedIndexChanged += new System.EventHandler(this.lbMaterialRentProductsInList_SelectedIndexChanged);
            // 
            // lblMaterialRentDetails
            // 
            this.lblMaterialRentDetails.AutoSize = true;
            this.lblMaterialRentDetails.Location = new System.Drawing.Point(34, 288);
            this.lblMaterialRentDetails.Name = "lblMaterialRentDetails";
            this.lblMaterialRentDetails.Size = new System.Drawing.Size(39, 13);
            this.lblMaterialRentDetails.TabIndex = 2;
            this.lblMaterialRentDetails.Text = "Details";
            // 
            // lblMaterialRentStatus
            // 
            this.lblMaterialRentStatus.AutoSize = true;
            this.lblMaterialRentStatus.Location = new System.Drawing.Point(34, 338);
            this.lblMaterialRentStatus.Name = "lblMaterialRentStatus";
            this.lblMaterialRentStatus.Size = new System.Drawing.Size(37, 13);
            this.lblMaterialRentStatus.TabIndex = 3;
            this.lblMaterialRentStatus.Text = "Status";
            // 
            // lblMaterialRentHireCost
            // 
            this.lblMaterialRentHireCost.AutoSize = true;
            this.lblMaterialRentHireCost.Location = new System.Drawing.Point(34, 312);
            this.lblMaterialRentHireCost.Name = "lblMaterialRentHireCost";
            this.lblMaterialRentHireCost.Size = new System.Drawing.Size(83, 13);
            this.lblMaterialRentHireCost.TabIndex = 4;
            this.lblMaterialRentHireCost.Text = "Huurkosten : 20";
            // 
            // lblMaterialRentScannedRfid
            // 
            this.lblMaterialRentScannedRfid.AutoSize = true;
            this.lblMaterialRentScannedRfid.Location = new System.Drawing.Point(321, 50);
            this.lblMaterialRentScannedRfid.Name = "lblMaterialRentScannedRfid";
            this.lblMaterialRentScannedRfid.Size = new System.Drawing.Size(93, 13);
            this.lblMaterialRentScannedRfid.TabIndex = 5;
            this.lblMaterialRentScannedRfid.Text = "Gescande RFID : ";
            // 
            // lblMaterialRentRfid
            // 
            this.lblMaterialRentRfid.AutoSize = true;
            this.lblMaterialRentRfid.Location = new System.Drawing.Point(321, 93);
            this.lblMaterialRentRfid.Name = "lblMaterialRentRfid";
            this.lblMaterialRentRfid.Size = new System.Drawing.Size(41, 13);
            this.lblMaterialRentRfid.TabIndex = 6;
            this.lblMaterialRentRfid.Text = "RFID : ";
            // 
            // lblMaterialRentName
            // 
            this.lblMaterialRentName.AutoSize = true;
            this.lblMaterialRentName.Location = new System.Drawing.Point(321, 131);
            this.lblMaterialRentName.Name = "lblMaterialRentName";
            this.lblMaterialRentName.Size = new System.Drawing.Size(68, 13);
            this.lblMaterialRentName.TabIndex = 7;
            this.lblMaterialRentName.Text = "Naam :  XXX";
            // 
            // lblMaterialRentChooseEndDate
            // 
            this.lblMaterialRentChooseEndDate.AutoSize = true;
            this.lblMaterialRentChooseEndDate.Location = new System.Drawing.Point(321, 206);
            this.lblMaterialRentChooseEndDate.Name = "lblMaterialRentChooseEndDate";
            this.lblMaterialRentChooseEndDate.Size = new System.Drawing.Size(91, 13);
            this.lblMaterialRentChooseEndDate.TabIndex = 8;
            this.lblMaterialRentChooseEndDate.Text = "Einddatum kiezen";
            // 
            // dateTimePickerMaterialRentEndDate
            // 
            this.dateTimePickerMaterialRentEndDate.Location = new System.Drawing.Point(324, 246);
            this.dateTimePickerMaterialRentEndDate.Name = "dateTimePickerMaterialRentEndDate";
            this.dateTimePickerMaterialRentEndDate.Size = new System.Drawing.Size(173, 20);
            this.dateTimePickerMaterialRentEndDate.TabIndex = 9;
            // 
            // btnMaterialRentConfirm
            // 
            this.btnMaterialRentConfirm.Location = new System.Drawing.Point(324, 298);
            this.btnMaterialRentConfirm.Name = "btnMaterialRentConfirm";
            this.btnMaterialRentConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnMaterialRentConfirm.TabIndex = 10;
            this.btnMaterialRentConfirm.Text = "Bevestigen";
            this.btnMaterialRentConfirm.UseVisualStyleBackColor = true;
            this.btnMaterialRentConfirm.Click += new System.EventHandler(this.btnMaterialRentConfirm_Click);
            // 
            // delayClean
            // 
            this.delayClean.Interval = 2000;
            // 
            // btnReattach
            // 
            this.btnReattach.Location = new System.Drawing.Point(34, 12);
            this.btnReattach.Name = "btnReattach";
            this.btnReattach.Size = new System.Drawing.Size(75, 23);
            this.btnReattach.TabIndex = 11;
            this.btnReattach.Text = "Reattachment";
            this.btnReattach.UseVisualStyleBackColor = true;
            // 
            // MaterialRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 425);
            this.Controls.Add(this.btnReattach);
            this.Controls.Add(this.btnMaterialRentConfirm);
            this.Controls.Add(this.dateTimePickerMaterialRentEndDate);
            this.Controls.Add(this.lblMaterialRentChooseEndDate);
            this.Controls.Add(this.lblMaterialRentName);
            this.Controls.Add(this.lblMaterialRentRfid);
            this.Controls.Add(this.lblMaterialRentScannedRfid);
            this.Controls.Add(this.lblMaterialRentHireCost);
            this.Controls.Add(this.lblMaterialRentStatus);
            this.Controls.Add(this.lblMaterialRentDetails);
            this.Controls.Add(this.lbMaterialRentProductsInList);
            this.Controls.Add(this.lblMaterialRentProductsInStorage);
            this.Name = "MaterialRent";
            this.Text = "MaterialRent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterialRentProductsInStorage;
        private System.Windows.Forms.ListBox lbMaterialRentProductsInList;
        private System.Windows.Forms.Label lblMaterialRentDetails;
        private System.Windows.Forms.Label lblMaterialRentStatus;
        private System.Windows.Forms.Label lblMaterialRentHireCost;
        private System.Windows.Forms.Label lblMaterialRentScannedRfid;
        private System.Windows.Forms.Label lblMaterialRentRfid;
        private System.Windows.Forms.Label lblMaterialRentName;
        private System.Windows.Forms.Label lblMaterialRentChooseEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaterialRentEndDate;
        private System.Windows.Forms.Button btnMaterialRentConfirm;
        private System.Windows.Forms.Timer delayClean;
        private System.Windows.Forms.Button btnReattach;
    }
}