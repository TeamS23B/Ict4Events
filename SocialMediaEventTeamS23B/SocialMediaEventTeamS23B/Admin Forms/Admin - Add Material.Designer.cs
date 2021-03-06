﻿namespace SocialMediaEventTeamS23B.Admin_Forms
{
    partial class Admin___Add_Material
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
            this.gbMaterial = new System.Windows.Forms.GroupBox();
            this.lvMaterial = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMaterial
            // 
            this.gbMaterial.Controls.Add(this.lvMaterial);
            this.gbMaterial.Location = new System.Drawing.Point(10, 11);
            this.gbMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.gbMaterial.Name = "gbMaterial";
            this.gbMaterial.Padding = new System.Windows.Forms.Padding(2);
            this.gbMaterial.Size = new System.Drawing.Size(458, 223);
            this.gbMaterial.TabIndex = 0;
            this.gbMaterial.TabStop = false;
            this.gbMaterial.Text = "Materiaal";
            // 
            // lvMaterial
            // 
            this.lvMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chType,
            this.chModel,
            this.chPrice,
            this.chState});
            this.lvMaterial.FullRowSelect = true;
            this.lvMaterial.Location = new System.Drawing.Point(5, 18);
            this.lvMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.lvMaterial.Name = "lvMaterial";
            this.lvMaterial.Size = new System.Drawing.Size(449, 201);
            this.lvMaterial.TabIndex = 0;
            this.lvMaterial.UseCompatibleStateImageBehavior = false;
            this.lvMaterial.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Tag = "";
            this.chId.Text = "Nr.";
            this.chId.Width = 45;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 118;
            // 
            // chModel
            // 
            this.chModel.Text = "Model";
            this.chModel.Width = 101;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Prijs";
            // 
            // chState
            // 
            this.chState.Text = "Staat";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(472, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(472, 66);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 50);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Bewerken";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(472, 121);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 50);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Verwijderen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(10, 270);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 50);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Admin___Add_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 330);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbMaterial);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin___Add_Material";
            this.Text = "Admin___Add_Material";
            this.Activated += new System.EventHandler(this.Admin___Add_Material_Activated);
            this.Load += new System.EventHandler(this.Admin___Add_Material_Load);
            this.gbMaterial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMaterial;
        private System.Windows.Forms.ListView lvMaterial;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chModel;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader chId;
    }
}