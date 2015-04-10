namespace SocialMediaEventTeamS23B
{
    partial class SMSAddCategory
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
            this.btnCategory = new System.Windows.Forms.Button();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.tbParentCategory = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.lblParentCat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(16, 68);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(254, 43);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Add Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(128, 12);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(142, 22);
            this.tbCategoryName.TabIndex = 1;
            // 
            // tbParentCategory
            // 
            this.tbParentCategory.Location = new System.Drawing.Point(128, 40);
            this.tbParentCategory.Name = "tbParentCategory";
            this.tbParentCategory.Size = new System.Drawing.Size(142, 22);
            this.tbParentCategory.TabIndex = 2;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(13, 12);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(110, 17);
            this.lblCatName.TabIndex = 3;
            this.lblCatName.Text = "Category Name:";
            // 
            // lblParentCat
            // 
            this.lblParentCat.AutoSize = true;
            this.lblParentCat.Location = new System.Drawing.Point(8, 43);
            this.lblParentCat.Name = "lblParentCat";
            this.lblParentCat.Size = new System.Drawing.Size(115, 17);
            this.lblParentCat.TabIndex = 4;
            this.lblParentCat.Text = "Parent Category:";
            // 
            // SMSAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 123);
            this.Controls.Add(this.lblParentCat);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.tbParentCategory);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.btnCategory);
            this.Name = "SMSAddCategory";
            this.Text = "SMSAddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.TextBox tbParentCategory;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Label lblParentCat;
    }
}