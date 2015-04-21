namespace SocialMediaEventTeamS23B.Beheer_Forms
{
    partial class Beheer___Event_Aanmaken
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
            this.lbAllMaterial = new System.Windows.Forms.ListBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.nudStartDay = new System.Windows.Forms.NumericUpDown();
            this.nudStartMonth = new System.Windows.Forms.NumericUpDown();
            this.nudStartYear = new System.Windows.Forms.NumericUpDown();
            this.nudEndYear = new System.Windows.Forms.NumericUpDown();
            this.nudEndMonth = new System.Windows.Forms.NumericUpDown();
            this.nudEndDay = new System.Windows.Forms.NumericUpDown();
            this.lblAllMaterial = new System.Windows.Forms.Label();
            this.lblMaterialOnLocation = new System.Windows.Forms.Label();
            this.lbMaterialOnLocation = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEventName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAllMaterial
            // 
            this.lbAllMaterial.FormattingEnabled = true;
            this.lbAllMaterial.Location = new System.Drawing.Point(261, 55);
            this.lbAllMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.lbAllMaterial.Name = "lbAllMaterial";
            this.lbAllMaterial.Size = new System.Drawing.Size(145, 329);
            this.lbAllMaterial.TabIndex = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(10, 101);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(42, 13);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Locatie";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(9, 125);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Startdatum";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(11, 149);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(57, 13);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "Einddatum";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(410, 138);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Toevoegen >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(410, 190);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 35);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Verwijderen <<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cbLocations
            // 
            this.cbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(112, 98);
            this.cbLocations.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(97, 21);
            this.cbLocations.TabIndex = 12;
            // 
            // nudStartDay
            // 
            this.nudStartDay.Location = new System.Drawing.Point(83, 123);
            this.nudStartDay.Margin = new System.Windows.Forms.Padding(2);
            this.nudStartDay.Name = "nudStartDay";
            this.nudStartDay.Size = new System.Drawing.Size(33, 20);
            this.nudStartDay.TabIndex = 13;
            this.nudStartDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudStartMonth
            // 
            this.nudStartMonth.Location = new System.Drawing.Point(120, 123);
            this.nudStartMonth.Margin = new System.Windows.Forms.Padding(2);
            this.nudStartMonth.Name = "nudStartMonth";
            this.nudStartMonth.Size = new System.Drawing.Size(33, 20);
            this.nudStartMonth.TabIndex = 14;
            this.nudStartMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudStartYear
            // 
            this.nudStartYear.Location = new System.Drawing.Point(157, 123);
            this.nudStartYear.Margin = new System.Windows.Forms.Padding(2);
            this.nudStartYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudStartYear.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudStartYear.Name = "nudStartYear";
            this.nudStartYear.Size = new System.Drawing.Size(52, 20);
            this.nudStartYear.TabIndex = 15;
            this.nudStartYear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // nudEndYear
            // 
            this.nudEndYear.Location = new System.Drawing.Point(157, 147);
            this.nudEndYear.Margin = new System.Windows.Forms.Padding(2);
            this.nudEndYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudEndYear.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudEndYear.Name = "nudEndYear";
            this.nudEndYear.Size = new System.Drawing.Size(52, 20);
            this.nudEndYear.TabIndex = 18;
            this.nudEndYear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // nudEndMonth
            // 
            this.nudEndMonth.Location = new System.Drawing.Point(120, 147);
            this.nudEndMonth.Margin = new System.Windows.Forms.Padding(2);
            this.nudEndMonth.Name = "nudEndMonth";
            this.nudEndMonth.Size = new System.Drawing.Size(33, 20);
            this.nudEndMonth.TabIndex = 17;
            this.nudEndMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudEndDay
            // 
            this.nudEndDay.Location = new System.Drawing.Point(83, 147);
            this.nudEndDay.Margin = new System.Windows.Forms.Padding(2);
            this.nudEndDay.Name = "nudEndDay";
            this.nudEndDay.Size = new System.Drawing.Size(33, 20);
            this.nudEndDay.TabIndex = 16;
            this.nudEndDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAllMaterial
            // 
            this.lblAllMaterial.AutoSize = true;
            this.lblAllMaterial.Location = new System.Drawing.Point(258, 29);
            this.lblAllMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllMaterial.Name = "lblAllMaterial";
            this.lblAllMaterial.Size = new System.Drawing.Size(70, 13);
            this.lblAllMaterial.TabIndex = 19;
            this.lblAllMaterial.Text = "Alle Materiaal";
            // 
            // lblMaterialOnLocation
            // 
            this.lblMaterialOnLocation.AutoSize = true;
            this.lblMaterialOnLocation.Location = new System.Drawing.Point(491, 29);
            this.lblMaterialOnLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialOnLocation.Name = "lblMaterialOnLocation";
            this.lblMaterialOnLocation.Size = new System.Drawing.Size(99, 13);
            this.lblMaterialOnLocation.TabIndex = 20;
            this.lblMaterialOnLocation.Text = "Materiaal op locatie";
            // 
            // lbMaterialOnLocation
            // 
            this.lbMaterialOnLocation.FormattingEnabled = true;
            this.lbMaterialOnLocation.Location = new System.Drawing.Point(494, 55);
            this.lbMaterialOnLocation.Margin = new System.Windows.Forms.Padding(2);
            this.lbMaterialOnLocation.Name = "lbMaterialOnLocation";
            this.lbMaterialOnLocation.Size = new System.Drawing.Size(145, 329);
            this.lbMaterialOnLocation.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 277);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 35);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(11, 74);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(35, 13);
            this.lblEventName.TabIndex = 23;
            this.lblEventName.Text = "Naam";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(112, 71);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(97, 20);
            this.tbName.TabIndex = 24;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(103, 190);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(106, 35);
            this.btnAddEvent.TabIndex = 26;
            this.btnAddEvent.Text = "Event toevoegen";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // Beheer___Event_Aanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 395);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbMaterialOnLocation);
            this.Controls.Add(this.lblMaterialOnLocation);
            this.Controls.Add(this.lblAllMaterial);
            this.Controls.Add(this.nudEndYear);
            this.Controls.Add(this.nudEndMonth);
            this.Controls.Add(this.nudEndDay);
            this.Controls.Add(this.nudStartYear);
            this.Controls.Add(this.nudStartMonth);
            this.Controls.Add(this.nudStartDay);
            this.Controls.Add(this.cbLocations);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lbAllMaterial);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Beheer___Event_Aanmaken";
            this.Text = "Beheer___Event_Aanmaken";
            ((System.ComponentModel.ISupportInitialize)(this.nudStartDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAllMaterial;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.NumericUpDown nudStartDay;
        private System.Windows.Forms.NumericUpDown nudStartMonth;
        private System.Windows.Forms.NumericUpDown nudStartYear;
        private System.Windows.Forms.NumericUpDown nudEndYear;
        private System.Windows.Forms.NumericUpDown nudEndMonth;
        private System.Windows.Forms.NumericUpDown nudEndDay;
        private System.Windows.Forms.Label lblAllMaterial;
        private System.Windows.Forms.Label lblMaterialOnLocation;
        private System.Windows.Forms.ListBox lbMaterialOnLocation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAddEvent;
    }
}