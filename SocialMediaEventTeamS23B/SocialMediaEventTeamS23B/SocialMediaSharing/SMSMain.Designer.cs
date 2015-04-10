namespace SocialMediaEventTeamS23B.SocialMediaSharing
{
    partial class SMSMain
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
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMyContent = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTrening = new System.Windows.Forms.Label();
            this.btNewMessage = new System.Windows.Forms.Button();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.tblLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 3;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.Controls.Add(this.panel1, 0, 1);
            this.tblLayout.Controls.Add(this.tbSearch, 1, 0);
            this.tblLayout.Controls.Add(this.panel2, 1, 1);
            this.tblLayout.Controls.Add(this.lblUsername, 0, 0);
            this.tblLayout.Controls.Add(this.panel3, 2, 1);
            this.tblLayout.Controls.Add(this.btNewMessage, 2, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 2;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.85042F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.14958F));
            this.tblLayout.Size = new System.Drawing.Size(912, 444);
            this.tblLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblMyContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 373);
            this.panel1.TabIndex = 1;
            // 
            // lblMyContent
            // 
            this.lblMyContent.AutoSize = true;
            this.lblMyContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyContent.Location = new System.Drawing.Point(4, 0);
            this.lblMyContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMyContent.Name = "lblMyContent";
            this.lblMyContent.Size = new System.Drawing.Size(166, 31);
            this.lblMyContent.TabIndex = 1;
            this.lblMyContent.Text = "Mijn Content";
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(274, 5);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(390, 55);
            this.tbSearch.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lblContent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(274, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 373);
            this.panel2.TabIndex = 3;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(4, 0);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(230, 31);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Nieuwste Content";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(4, 0);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(139, 31);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lblTrening);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(674, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 373);
            this.panel3.TabIndex = 4;
            // 
            // lblTrening
            // 
            this.lblTrening.AutoSize = true;
            this.lblTrening.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrening.Location = new System.Drawing.Point(4, 0);
            this.lblTrening.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrening.Name = "lblTrening";
            this.lblTrening.Size = new System.Drawing.Size(121, 31);
            this.lblTrening.TabIndex = 3;
            this.lblTrening.Text = "Trending";
            // 
            // btNewMessage
            // 
            this.btNewMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btNewMessage.Location = new System.Drawing.Point(674, 5);
            this.btNewMessage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btNewMessage.Name = "btNewMessage";
            this.btNewMessage.Size = new System.Drawing.Size(237, 51);
            this.btNewMessage.TabIndex = 5;
            this.btNewMessage.Text = "Nieuw Bericht";
            this.btNewMessage.UseVisualStyleBackColor = true;
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 1000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // SMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 444);
            this.Controls.Add(this.tblLayout);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SMSMain";
            this.Text = "Social Media Sharing";
            this.Load += new System.EventHandler(this.SMSMain_Load);
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMyContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTrening;
        private System.Windows.Forms.Button btNewMessage;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}