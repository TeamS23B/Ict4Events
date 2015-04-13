namespace SocialMediaEventTeamS23B
{
    partial class Admin___Add_Material___Add
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.tbEuros = new System.Windows.Forms.TextBox();
            this.tbCents = new System.Windows.Forms.TextBox();
            this.lblComma = new System.Windows.Forms.Label();
            this.lblHuurPrijs = new System.Windows.Forms.Label();
            this.tbAdminEuros = new System.Windows.Forms.TextBox();
            this.tbAdminCents = new System.Windows.Forms.TextBox();
            this.lblComma2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 129);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Voeg Toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(10, 14);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(10, 36);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(10, 59);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Prijs:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(10, 107);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "Staat:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Videocamera",
            "Fotocamera",
            "Laptop",
            "Smartphone",
            "Tablet",
            "Lader",
            "Accu",
            "SD-Kaart",
            "Muis",
            "USB-Stick"});
            this.cbType.Location = new System.Drawing.Point(76, 11);
            this.cbType.Margin = new System.Windows.Forms.Padding(2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(127, 21);
            this.cbType.TabIndex = 9;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(76, 33);
            this.cbModel.Margin = new System.Windows.Forms.Padding(2);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(127, 21);
            this.cbModel.TabIndex = 10;
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "Nieuw",
            "Gebruikt",
            "Beschadigd",
            "Defect"});
            this.cbState.Location = new System.Drawing.Point(76, 104);
            this.cbState.Margin = new System.Windows.Forms.Padding(2);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(127, 21);
            this.cbState.TabIndex = 11;
            // 
            // tbEuros
            // 
            this.tbEuros.Location = new System.Drawing.Point(76, 56);
            this.tbEuros.Margin = new System.Windows.Forms.Padding(2);
            this.tbEuros.Name = "tbEuros";
            this.tbEuros.Size = new System.Drawing.Size(62, 20);
            this.tbEuros.TabIndex = 12;
            // 
            // tbCents
            // 
            this.tbCents.Location = new System.Drawing.Point(156, 56);
            this.tbCents.Margin = new System.Windows.Forms.Padding(2);
            this.tbCents.Name = "tbCents";
            this.tbCents.Size = new System.Drawing.Size(48, 20);
            this.tbCents.TabIndex = 13;
            // 
            // lblComma
            // 
            this.lblComma.AutoSize = true;
            this.lblComma.Location = new System.Drawing.Point(142, 60);
            this.lblComma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComma.Name = "lblComma";
            this.lblComma.Size = new System.Drawing.Size(10, 13);
            this.lblComma.TabIndex = 14;
            this.lblComma.Text = ",";
            // 
            // lblHuurPrijs
            // 
            this.lblHuurPrijs.AutoSize = true;
            this.lblHuurPrijs.Location = new System.Drawing.Point(10, 83);
            this.lblHuurPrijs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHuurPrijs.Name = "lblHuurPrijs";
            this.lblHuurPrijs.Size = new System.Drawing.Size(55, 13);
            this.lblHuurPrijs.TabIndex = 15;
            this.lblHuurPrijs.Text = "Huur Prijs:";
            // 
            // tbAdminEuros
            // 
            this.tbAdminEuros.Location = new System.Drawing.Point(76, 80);
            this.tbAdminEuros.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdminEuros.Name = "tbAdminEuros";
            this.tbAdminEuros.Size = new System.Drawing.Size(62, 20);
            this.tbAdminEuros.TabIndex = 16;
            // 
            // tbAdminCents
            // 
            this.tbAdminCents.Location = new System.Drawing.Point(156, 80);
            this.tbAdminCents.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdminCents.Name = "tbAdminCents";
            this.tbAdminCents.Size = new System.Drawing.Size(48, 20);
            this.tbAdminCents.TabIndex = 17;
            // 
            // lblComma2
            // 
            this.lblComma2.AutoSize = true;
            this.lblComma2.Location = new System.Drawing.Point(142, 83);
            this.lblComma2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComma2.Name = "lblComma2";
            this.lblComma2.Size = new System.Drawing.Size(10, 13);
            this.lblComma2.TabIndex = 18;
            this.lblComma2.Text = ",";
            // 
            // Admin___Add_Material___Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 186);
            this.Controls.Add(this.lblComma2);
            this.Controls.Add(this.tbAdminCents);
            this.Controls.Add(this.tbAdminEuros);
            this.Controls.Add(this.lblHuurPrijs);
            this.Controls.Add(this.lblComma);
            this.Controls.Add(this.tbCents);
            this.Controls.Add(this.tbEuros);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin___Add_Material___Add";
            this.Text = "Admin___Add_Material___Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox tbEuros;
        private System.Windows.Forms.TextBox tbCents;
        private System.Windows.Forms.Label lblComma;
        private System.Windows.Forms.Label lblHuurPrijs;
        private System.Windows.Forms.TextBox tbAdminEuros;
        private System.Windows.Forms.TextBox tbAdminCents;
        private System.Windows.Forms.Label lblComma2;
    }
}