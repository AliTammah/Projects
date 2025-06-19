namespace project19
{
    partial class frmManageInternationalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInternationalLicense));
            this.lbNumberRecords = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.dgvInternational = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrFilterLocalDrivingApplications1 = new project19.ctrFilterLocalDrivingApplications();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumberRecords
            // 
            this.lbNumberRecords.AutoSize = true;
            this.lbNumberRecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNumberRecords.Location = new System.Drawing.Point(99, 551);
            this.lbNumberRecords.Name = "lbNumberRecords";
            this.lbNumberRecords.Size = new System.Drawing.Size(33, 19);
            this.lbNumberRecords.TabIndex = 34;
            this.lbNumberRecords.Text = "???";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbRecords.Location = new System.Drawing.Point(20, 551);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(83, 19);
            this.lbRecords.TabIndex = 33;
            this.lbRecords.Text = "#Records:";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(784, 544);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 31;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // dgvInternational
            // 
            this.dgvInternational.AllowDrop = true;
            this.dgvInternational.AllowUserToOrderColumns = true;
            this.dgvInternational.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternational.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternational.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInternational.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInternational.Location = new System.Drawing.Point(20, 280);
            this.dgvInternational.Name = "dgvInternational";
            this.dgvInternational.ReadOnly = true;
            this.dgvInternational.Size = new System.Drawing.Size(883, 248);
            this.dgvInternational.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(297, 118);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showLicenseDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseDetailsToolStripMenuItem.Image")));
            this.showLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonToolStripMenuItem
            // 
            this.showPersonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonToolStripMenuItem.Image")));
            this.showPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
            this.showPersonToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.showPersonToolStripMenuItem.Text = "Show Person  License History";
            this.showPersonToolStripMenuItem.Click += new System.EventHandler(this.showPersonToolStripMenuItem_Click);
            // 
            // btAddPerson
            // 
            this.btAddPerson.BackColor = System.Drawing.Color.White;
            this.btAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btAddPerson.Image")));
            this.btAddPerson.Location = new System.Drawing.Point(825, 199);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(78, 75);
            this.btAddPerson.TabIndex = 29;
            this.btAddPerson.Tag = "1";
            this.btAddPerson.UseVisualStyleBackColor = false;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("Tahoma", 17F);
            this.lbManagePeople.ForeColor = System.Drawing.Color.Red;
            this.lbManagePeople.Location = new System.Drawing.Point(231, 162);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(429, 28);
            this.lbManagePeople.TabIndex = 28;
            this.lbManagePeople.Text = "International Driving License Applications";
            // 
            // pbPeople
            // 
            this.pbPeople.Image = ((System.Drawing.Image)(resources.GetObject("pbPeople.Image")));
            this.pbPeople.Location = new System.Drawing.Point(318, 5);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(149, 144);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 27;
            this.pbPeople.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // ctrFilterLocalDrivingApplications1
            // 
            this.ctrFilterLocalDrivingApplications1.FilterColumns = null;
            this.ctrFilterLocalDrivingApplications1.Location = new System.Drawing.Point(20, 193);
            this.ctrFilterLocalDrivingApplications1.Name = "ctrFilterLocalDrivingApplications1";
            this.ctrFilterLocalDrivingApplications1.Size = new System.Drawing.Size(476, 78);
            this.ctrFilterLocalDrivingApplications1.SourceData = null;
            this.ctrFilterLocalDrivingApplications1.TabIndex = 36;
            this.ctrFilterLocalDrivingApplications1.TargetGrid = null;
            this.ctrFilterLocalDrivingApplications1.OnFilterLocalApplications += new System.Action<string>(this.ctrFilterLocalDrivingApplications1_OnFilterLocalApplications);
            // 
            // frmManageInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 591);
            this.Controls.Add(this.ctrFilterLocalDrivingApplications1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNumberRecords);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dgvInternational);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.lbManagePeople);
            this.Controls.Add(this.pbPeople);
            this.Name = "frmManageInternationalLicense";
            this.Text = "frmManageInternationalLicense";
            this.Load += new System.EventHandler(this.frmManageInternationalLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumberRecords;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView dgvInternational;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonToolStripMenuItem;
        private ctrFilterLocalDrivingApplications ctrFilterLocalDrivingApplications1;
    }
}