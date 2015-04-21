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
            this.lbHereComeTheDetails = new System.Windows.Forms.Label();
            this.lblHereComeTheRentCosts = new System.Windows.Forms.Label();
            this.lblHereComeTheStats = new System.Windows.Forms.Label();
            this.btnConfirmItemRent = new System.Windows.Forms.Button();
            this.gbRfidScan = new System.Windows.Forms.GroupBox();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.lbGereserveerdMateriaal = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRfidScan.SuspendLayout();
            this.gbProducts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaterialRentProductsInStorage
            // 
            this.lblMaterialRentProductsInStorage.AutoSize = true;
            this.lblMaterialRentProductsInStorage.Location = new System.Drawing.Point(27, 16);
            this.lblMaterialRentProductsInStorage.Name = "lblMaterialRentProductsInStorage";
            this.lblMaterialRentProductsInStorage.Size = new System.Drawing.Size(116, 13);
            this.lblMaterialRentProductsInStorage.TabIndex = 0;
            this.lblMaterialRentProductsInStorage.Text = "Producten op voorraad";
            // 
            // lbMaterialRentProductsInList
            // 
            this.lbMaterialRentProductsInList.FormattingEnabled = true;
            this.lbMaterialRentProductsInList.Location = new System.Drawing.Point(30, 42);
            this.lbMaterialRentProductsInList.Name = "lbMaterialRentProductsInList";
            this.lbMaterialRentProductsInList.Size = new System.Drawing.Size(134, 173);
            this.lbMaterialRentProductsInList.TabIndex = 1;
            this.lbMaterialRentProductsInList.SelectedIndexChanged += new System.EventHandler(this.lbMaterialRentProductsInList_SelectedIndexChanged);
            // 
            // lblMaterialRentDetails
            // 
            this.lblMaterialRentDetails.AutoSize = true;
            this.lblMaterialRentDetails.Location = new System.Drawing.Point(27, 247);
            this.lblMaterialRentDetails.Name = "lblMaterialRentDetails";
            this.lblMaterialRentDetails.Size = new System.Drawing.Size(39, 13);
            this.lblMaterialRentDetails.TabIndex = 2;
            this.lblMaterialRentDetails.Text = "Details";
            // 
            // lblMaterialRentStatus
            // 
            this.lblMaterialRentStatus.AutoSize = true;
            this.lblMaterialRentStatus.Location = new System.Drawing.Point(27, 297);
            this.lblMaterialRentStatus.Name = "lblMaterialRentStatus";
            this.lblMaterialRentStatus.Size = new System.Drawing.Size(37, 13);
            this.lblMaterialRentStatus.TabIndex = 3;
            this.lblMaterialRentStatus.Text = "Status";
            // 
            // lblMaterialRentHireCost
            // 
            this.lblMaterialRentHireCost.AutoSize = true;
            this.lblMaterialRentHireCost.Location = new System.Drawing.Point(26, 271);
            this.lblMaterialRentHireCost.Name = "lblMaterialRentHireCost";
            this.lblMaterialRentHireCost.Size = new System.Drawing.Size(71, 13);
            this.lblMaterialRentHireCost.TabIndex = 4;
            this.lblMaterialRentHireCost.Text = "Huurkosten : ";
            // 
            // lblMaterialRentScannedRfid
            // 
            this.lblMaterialRentScannedRfid.AutoSize = true;
            this.lblMaterialRentScannedRfid.Location = new System.Drawing.Point(27, 29);
            this.lblMaterialRentScannedRfid.Name = "lblMaterialRentScannedRfid";
            this.lblMaterialRentScannedRfid.Size = new System.Drawing.Size(93, 13);
            this.lblMaterialRentScannedRfid.TabIndex = 5;
            this.lblMaterialRentScannedRfid.Text = "Gescande RFID : ";
            // 
            // lblMaterialRentRfid
            // 
            this.lblMaterialRentRfid.AutoSize = true;
            this.lblMaterialRentRfid.Location = new System.Drawing.Point(27, 53);
            this.lblMaterialRentRfid.Name = "lblMaterialRentRfid";
            this.lblMaterialRentRfid.Size = new System.Drawing.Size(41, 13);
            this.lblMaterialRentRfid.TabIndex = 6;
            this.lblMaterialRentRfid.Text = "RFID : ";
            // 
            // lblMaterialRentName
            // 
            this.lblMaterialRentName.AutoSize = true;
            this.lblMaterialRentName.Location = new System.Drawing.Point(27, 82);
            this.lblMaterialRentName.Name = "lblMaterialRentName";
            this.lblMaterialRentName.Size = new System.Drawing.Size(68, 13);
            this.lblMaterialRentName.TabIndex = 7;
            this.lblMaterialRentName.Text = "Naam :  XXX";
            // 
            // lblMaterialRentChooseEndDate
            // 
            this.lblMaterialRentChooseEndDate.AutoSize = true;
            this.lblMaterialRentChooseEndDate.Location = new System.Drawing.Point(18, 147);
            this.lblMaterialRentChooseEndDate.Name = "lblMaterialRentChooseEndDate";
            this.lblMaterialRentChooseEndDate.Size = new System.Drawing.Size(91, 13);
            this.lblMaterialRentChooseEndDate.TabIndex = 8;
            this.lblMaterialRentChooseEndDate.Text = "Einddatum kiezen";
            // 
            // dateTimePickerMaterialRentEndDate
            // 
            this.dateTimePickerMaterialRentEndDate.Location = new System.Drawing.Point(6, 195);
            this.dateTimePickerMaterialRentEndDate.Name = "dateTimePickerMaterialRentEndDate";
            this.dateTimePickerMaterialRentEndDate.Size = new System.Drawing.Size(173, 20);
            this.dateTimePickerMaterialRentEndDate.TabIndex = 9;
            // 
            // btnMaterialRentConfirm
            // 
            this.btnMaterialRentConfirm.Location = new System.Drawing.Point(20, 256);
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
            this.delayClean.Tick += new System.EventHandler(this.delayClean_Tick);
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
            // lbHereComeTheDetails
            // 
            this.lbHereComeTheDetails.AutoSize = true;
            this.lbHereComeTheDetails.Location = new System.Drawing.Point(111, 288);
            this.lbHereComeTheDetails.Name = "lbHereComeTheDetails";
            this.lbHereComeTheDetails.Size = new System.Drawing.Size(0, 13);
            this.lbHereComeTheDetails.TabIndex = 12;
            // 
            // lblHereComeTheRentCosts
            // 
            this.lblHereComeTheRentCosts.AutoSize = true;
            this.lblHereComeTheRentCosts.Location = new System.Drawing.Point(111, 312);
            this.lblHereComeTheRentCosts.Name = "lblHereComeTheRentCosts";
            this.lblHereComeTheRentCosts.Size = new System.Drawing.Size(0, 13);
            this.lblHereComeTheRentCosts.TabIndex = 13;
            // 
            // lblHereComeTheStats
            // 
            this.lblHereComeTheStats.AutoSize = true;
            this.lblHereComeTheStats.Location = new System.Drawing.Point(111, 338);
            this.lblHereComeTheStats.Name = "lblHereComeTheStats";
            this.lblHereComeTheStats.Size = new System.Drawing.Size(0, 13);
            this.lblHereComeTheStats.TabIndex = 14;
            // 
            // btnConfirmItemRent
            // 
            this.btnConfirmItemRent.Location = new System.Drawing.Point(89, 313);
            this.btnConfirmItemRent.Name = "btnConfirmItemRent";
            this.btnConfirmItemRent.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmItemRent.TabIndex = 15;
            this.btnConfirmItemRent.Text = "Bevestigen";
            this.btnConfirmItemRent.UseVisualStyleBackColor = true;
            this.btnConfirmItemRent.Click += new System.EventHandler(this.btnConfirmItemRent_Click);
            // 
            // gbRfidScan
            // 
            this.gbRfidScan.Controls.Add(this.lblMaterialRentScannedRfid);
            this.gbRfidScan.Controls.Add(this.lblMaterialRentRfid);
            this.gbRfidScan.Controls.Add(this.lblMaterialRentName);
            this.gbRfidScan.Controls.Add(this.lblMaterialRentChooseEndDate);
            this.gbRfidScan.Controls.Add(this.dateTimePickerMaterialRentEndDate);
            this.gbRfidScan.Controls.Add(this.btnMaterialRentConfirm);
            this.gbRfidScan.Location = new System.Drawing.Point(279, 41);
            this.gbRfidScan.Name = "gbRfidScan";
            this.gbRfidScan.Size = new System.Drawing.Size(197, 352);
            this.gbRfidScan.TabIndex = 16;
            this.gbRfidScan.TabStop = false;
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.btnConfirmItemRent);
            this.gbProducts.Controls.Add(this.lblMaterialRentProductsInStorage);
            this.gbProducts.Controls.Add(this.lbMaterialRentProductsInList);
            this.gbProducts.Controls.Add(this.lblMaterialRentDetails);
            this.gbProducts.Controls.Add(this.lblMaterialRentHireCost);
            this.gbProducts.Controls.Add(this.lblMaterialRentStatus);
            this.gbProducts.Location = new System.Drawing.Point(12, 41);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(197, 352);
            this.gbProducts.TabIndex = 17;
            this.gbProducts.TabStop = false;
            // 
            // lbGereserveerdMateriaal
            // 
            this.lbGereserveerdMateriaal.FormattingEnabled = true;
            this.lbGereserveerdMateriaal.Location = new System.Drawing.Point(34, 42);
            this.lbGereserveerdMateriaal.Name = "lbGereserveerdMateriaal";
            this.lbGereserveerdMateriaal.Size = new System.Drawing.Size(134, 173);
            this.lbGereserveerdMateriaal.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbGereserveerdMateriaal);
            this.groupBox1.Location = new System.Drawing.Point(544, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 352);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gereserveerd materiaal";
            // 
            // MaterialRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHereComeTheStats);
            this.Controls.Add(this.lblHereComeTheRentCosts);
            this.Controls.Add(this.lbHereComeTheDetails);
            this.Controls.Add(this.btnReattach);
            this.Controls.Add(this.gbRfidScan);
            this.Controls.Add(this.gbProducts);
            this.Name = "MaterialRent";
            this.Text = "MaterialRent";
            this.gbRfidScan.ResumeLayout(false);
            this.gbRfidScan.PerformLayout();
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lbHereComeTheDetails;
        private System.Windows.Forms.Label lblHereComeTheRentCosts;
        private System.Windows.Forms.Label lblHereComeTheStats;
        private System.Windows.Forms.Button btnConfirmItemRent;
        private System.Windows.Forms.GroupBox gbRfidScan;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.ListBox lbGereserveerdMateriaal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}