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
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(254, 54);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Voeg Toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 13);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(13, 41);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 17);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 69);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 17);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Prijs:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(13, 97);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(45, 17);
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
            this.cbType.Location = new System.Drawing.Point(102, 13);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(168, 24);
            this.cbType.TabIndex = 9;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(102, 41);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(168, 24);
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
            this.cbState.Location = new System.Drawing.Point(102, 97);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(168, 24);
            this.cbState.TabIndex = 11;
            // 
            // tbEuros
            // 
            this.tbEuros.Location = new System.Drawing.Point(102, 69);
            this.tbEuros.Name = "tbEuros";
            this.tbEuros.Size = new System.Drawing.Size(81, 22);
            this.tbEuros.TabIndex = 12;
            // 
            // tbCents
            // 
            this.tbCents.Location = new System.Drawing.Point(208, 69);
            this.tbCents.Name = "tbCents";
            this.tbCents.Size = new System.Drawing.Size(62, 22);
            this.tbCents.TabIndex = 13;
            // 
            // lblComma
            // 
            this.lblComma.AutoSize = true;
            this.lblComma.Location = new System.Drawing.Point(189, 74);
            this.lblComma.Name = "lblComma";
            this.lblComma.Size = new System.Drawing.Size(12, 17);
            this.lblComma.TabIndex = 14;
            this.lblComma.Text = ",";
            // 
            // Admin___Add_Material___Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 191);
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
    }
}