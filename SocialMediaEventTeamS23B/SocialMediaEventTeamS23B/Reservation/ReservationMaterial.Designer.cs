namespace SocialMediaEventTeamS23B
{
    partial class ReservationMaterial
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
            this.lbReservationReserved = new System.Windows.Forms.ListBox();
            this.lbReservationNotReserved = new System.Windows.Forms.ListBox();
            this.lblReservationNotReserved = new System.Windows.Forms.Label();
            this.lblReservationReserved = new System.Windows.Forms.Label();
            this.btnReservationAddMaterial = new System.Windows.Forms.Button();
            this.btnReservationRemoveMaterial = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblReservationEuro = new System.Windows.Forms.Label();
            this.lblReservationMaterialCost = new System.Windows.Forms.Label();
            this.btnReservationMaterialNext = new System.Windows.Forms.Button();
            this.btnReservationMaterialPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbReservationReserved
            // 
            this.lbReservationReserved.FormattingEnabled = true;
            this.lbReservationReserved.Location = new System.Drawing.Point(12, 29);
            this.lbReservationReserved.Name = "lbReservationReserved";
            this.lbReservationReserved.Size = new System.Drawing.Size(188, 342);
            this.lbReservationReserved.TabIndex = 0;
            // 
            // lbReservationNotReserved
            // 
            this.lbReservationNotReserved.FormattingEnabled = true;
            this.lbReservationNotReserved.Location = new System.Drawing.Point(354, 29);
            this.lbReservationNotReserved.Name = "lbReservationNotReserved";
            this.lbReservationNotReserved.Size = new System.Drawing.Size(188, 342);
            this.lbReservationNotReserved.TabIndex = 1;
            // 
            // lblReservationNotReserved
            // 
            this.lblReservationNotReserved.Location = new System.Drawing.Point(354, 9);
            this.lblReservationNotReserved.Name = "lblReservationNotReserved";
            this.lblReservationNotReserved.Size = new System.Drawing.Size(188, 13);
            this.lblReservationNotReserved.TabIndex = 3;
            this.lblReservationNotReserved.Text = "Nog niet gereserveerd materiaal";
            this.lblReservationNotReserved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReservationReserved
            // 
            this.lblReservationReserved.Location = new System.Drawing.Point(12, 9);
            this.lblReservationReserved.Name = "lblReservationReserved";
            this.lblReservationReserved.Size = new System.Drawing.Size(188, 13);
            this.lblReservationReserved.TabIndex = 4;
            this.lblReservationReserved.Text = "Gereserveerd materiaal";
            this.lblReservationReserved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReservationAddMaterial
            // 
            this.btnReservationAddMaterial.Location = new System.Drawing.Point(206, 157);
            this.btnReservationAddMaterial.Name = "btnReservationAddMaterial";
            this.btnReservationAddMaterial.Size = new System.Drawing.Size(142, 23);
            this.btnReservationAddMaterial.TabIndex = 5;
            this.btnReservationAddMaterial.Text = "<<Toevoegen";
            this.btnReservationAddMaterial.UseVisualStyleBackColor = true;
            this.btnReservationAddMaterial.Click += new System.EventHandler(this.btnReservationAddMaterial_Click);
            // 
            // btnReservationRemoveMaterial
            // 
            this.btnReservationRemoveMaterial.Location = new System.Drawing.Point(206, 215);
            this.btnReservationRemoveMaterial.Name = "btnReservationRemoveMaterial";
            this.btnReservationRemoveMaterial.Size = new System.Drawing.Size(142, 23);
            this.btnReservationRemoveMaterial.TabIndex = 6;
            this.btnReservationRemoveMaterial.Text = "Verwijderen>>";
            this.btnReservationRemoveMaterial.UseVisualStyleBackColor = true;
            this.btnReservationRemoveMaterial.Click += new System.EventHandler(this.btnReservationRemoveMaterial_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(15, 378);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "Totalebedrag";
            // 
            // lblReservationEuro
            // 
            this.lblReservationEuro.AutoSize = true;
            this.lblReservationEuro.Location = new System.Drawing.Point(24, 401);
            this.lblReservationEuro.Name = "lblReservationEuro";
            this.lblReservationEuro.Size = new System.Drawing.Size(13, 13);
            this.lblReservationEuro.TabIndex = 8;
            this.lblReservationEuro.Text = "€";
            // 
            // lblReservationMaterialCost
            // 
            this.lblReservationMaterialCost.AutoSize = true;
            this.lblReservationMaterialCost.Location = new System.Drawing.Point(43, 401);
            this.lblReservationMaterialCost.Name = "lblReservationMaterialCost";
            this.lblReservationMaterialCost.Size = new System.Drawing.Size(28, 13);
            this.lblReservationMaterialCost.TabIndex = 9;
            this.lblReservationMaterialCost.Text = "0,00";
            // 
            // btnReservationMaterialNext
            // 
            this.btnReservationMaterialNext.Location = new System.Drawing.Point(397, 437);
            this.btnReservationMaterialNext.Name = "btnReservationMaterialNext";
            this.btnReservationMaterialNext.Size = new System.Drawing.Size(145, 23);
            this.btnReservationMaterialNext.TabIndex = 28;
            this.btnReservationMaterialNext.Text = "Volgende stap";
            this.btnReservationMaterialNext.UseVisualStyleBackColor = true;
            this.btnReservationMaterialNext.Click += new System.EventHandler(this.btnReservationMaterialNext_Click);
            // 
            // btnReservationMaterialPrevious
            // 
            this.btnReservationMaterialPrevious.Location = new System.Drawing.Point(12, 437);
            this.btnReservationMaterialPrevious.Name = "btnReservationMaterialPrevious";
            this.btnReservationMaterialPrevious.Size = new System.Drawing.Size(145, 23);
            this.btnReservationMaterialPrevious.TabIndex = 29;
            this.btnReservationMaterialPrevious.Text = "Terug";
            this.btnReservationMaterialPrevious.UseVisualStyleBackColor = true;
            this.btnReservationMaterialPrevious.Click += new System.EventHandler(this.btnReservationMaterialPrevious_Click);
            // 
            // ReservationMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 472);
            this.Controls.Add(this.btnReservationMaterialPrevious);
            this.Controls.Add(this.btnReservationMaterialNext);
            this.Controls.Add(this.lblReservationMaterialCost);
            this.Controls.Add(this.lblReservationEuro);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnReservationRemoveMaterial);
            this.Controls.Add(this.btnReservationAddMaterial);
            this.Controls.Add(this.lblReservationReserved);
            this.Controls.Add(this.lblReservationNotReserved);
            this.Controls.Add(this.lbReservationNotReserved);
            this.Controls.Add(this.lbReservationReserved);
            this.Name = "ReservationMaterial";
            this.Text = "ReservationMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReservationReserved;
        private System.Windows.Forms.ListBox lbReservationNotReserved;
        private System.Windows.Forms.Label lblReservationNotReserved;
        private System.Windows.Forms.Label lblReservationReserved;
        private System.Windows.Forms.Button btnReservationAddMaterial;
        private System.Windows.Forms.Button btnReservationRemoveMaterial;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblReservationEuro;
        private System.Windows.Forms.Label lblReservationMaterialCost;
        private System.Windows.Forms.Button btnReservationMaterialNext;
        private System.Windows.Forms.Button btnReservationMaterialPrevious;
    }
}