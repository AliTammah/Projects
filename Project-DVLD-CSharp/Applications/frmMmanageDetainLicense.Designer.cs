namespace project19.Applications
{
    partial class frmMmanageDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMmanageDetainLicense));
            this.lbNumberRecords = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.ctrFilterLocalDrivingApplications1 = new project19.ctrFilterLocalDrivingApplications();
            this.btClose = new System.Windows.Forms.Button();
            this.bDetain = new System.Windows.Forms.Button();
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.btRelease = new System.Windows.Forms.Button();
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainsLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumberRecords
            // 
            this.lbNumberRecords.AutoSize = true;
            this.lbNumberRecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNumberRecords.Location = new System.Drawing.Point(93, 505);
            this.lbNumberRecords.Name = "lbNumberRecords";
            this.lbNumberRecords.Size = new System.Drawing.Size(33, 19);
            this.lbNumberRecords.TabIndex = 34;
            this.lbNumberRecords.Text = "???";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbRecords.Location = new System.Drawing.Point(4, 505);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(83, 19);
            this.lbRecords.TabIndex = 33;
            this.lbRecords.Text = "#Records:";
            // 
            // ctrFilterLocalDrivingApplications1
            // 
            this.ctrFilterLocalDrivingApplications1.FilterColumns = null;
            this.ctrFilterLocalDrivingApplications1.Location = new System.Drawing.Point(12, 201);
            this.ctrFilterLocalDrivingApplications1.Name = "ctrFilterLocalDrivingApplications1";
            this.ctrFilterLocalDrivingApplications1.Size = new System.Drawing.Size(430, 75);
            this.ctrFilterLocalDrivingApplications1.SourceData = null;
            this.ctrFilterLocalDrivingApplications1.TabIndex = 32;
            this.ctrFilterLocalDrivingApplications1.TargetGrid = null;
            this.ctrFilterLocalDrivingApplications1.OnFilterLocalApplications += new System.Action<string>(this.ctrFilterLocalDrivingApplications1_OnFilterLocalApplications);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(766, 497);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 31;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // bDetain
            // 
            this.bDetain.BackColor = System.Drawing.Color.White;
            this.bDetain.Image = ((System.Drawing.Image)(resources.GetObject("bDetain.Image")));
            this.bDetain.Location = new System.Drawing.Point(822, 201);
            this.bDetain.Name = "bDetain";
            this.bDetain.Size = new System.Drawing.Size(63, 65);
            this.bDetain.TabIndex = 29;
            this.bDetain.Tag = "1";
            this.bDetain.UseVisualStyleBackColor = false;
            this.bDetain.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("Tahoma", 17F);
            this.lbManagePeople.ForeColor = System.Drawing.Color.Red;
            this.lbManagePeople.Location = new System.Drawing.Point(329, 170);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(235, 28);
            this.lbManagePeople.TabIndex = 28;
            this.lbManagePeople.Text = "List Detained Licenses";
            this.lbManagePeople.Click += new System.EventHandler(this.lbManagePeople_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.Image = ((System.Drawing.Image)(resources.GetObject("pbPeople.Image")));
            this.pbPeople.Location = new System.Drawing.Point(371, 11);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(149, 144);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 27;
            this.pbPeople.TabStop = false;
            // 
            // btRelease
            // 
            this.btRelease.BackColor = System.Drawing.Color.White;
            this.btRelease.Image = ((System.Drawing.Image)(resources.GetObject("btRelease.Image")));
            this.btRelease.Location = new System.Drawing.Point(751, 201);
            this.btRelease.Name = "btRelease";
            this.btRelease.Size = new System.Drawing.Size(65, 65);
            this.btRelease.TabIndex = 35;
            this.btRelease.Tag = "1";
            this.btRelease.UseVisualStyleBackColor = false;
            this.btRelease.Click += new System.EventHandler(this.btRelease_Click);
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(8, 272);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(877, 210);
            this.dgvDetainedLicenses.TabIndex = 36;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseInfoToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.releaseDetainsLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(293, 156);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonDetailsToolStripMenuItem.Image")));
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(292, 38);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseInfoToolStripMenuItem.Image")));
            this.showLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(292, 38);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(292, 38);
            this.showLicenseToolStripMenuItem.Text = "Show Person License Details";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainsLicenseToolStripMenuItem
            // 
            this.releaseDetainsLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseDetainsLicenseToolStripMenuItem.Image")));
            this.releaseDetainsLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainsLicenseToolStripMenuItem.Name = "releaseDetainsLicenseToolStripMenuItem";
            this.releaseDetainsLicenseToolStripMenuItem.Size = new System.Drawing.Size(292, 38);
            this.releaseDetainsLicenseToolStripMenuItem.Text = "Release Detains License";
            this.releaseDetainsLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainsLicenseToolStripMenuItem_Click);
            // 
            // frmMmanageDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 536);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.btRelease);
            this.Controls.Add(this.lbNumberRecords);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.ctrFilterLocalDrivingApplications1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.bDetain);
            this.Controls.Add(this.lbManagePeople);
            this.Controls.Add(this.pbPeople);
            this.Name = "frmMmanageDetainLicense";
            this.Text = "frmMmanageDetainLicense";
            this.Load += new System.EventHandler(this.frmMmanageDetainLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumberRecords;
        private System.Windows.Forms.Label lbRecords;
        private ctrFilterLocalDrivingApplications ctrFilterLocalDrivingApplications1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button bDetain;
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.Button btRelease;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainsLicenseToolStripMenuItem;
    }
}