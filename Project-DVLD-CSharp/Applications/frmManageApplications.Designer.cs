namespace project19
{
    partial class frmManageApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplications));
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.EditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApp = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelApp = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.WrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.StreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueDriving = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ShoHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.lbNumberRecords = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.ctrFilterLocalDrivingApplications1 = new project19.ctrFilterLocalDrivingApplications();
            this.cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("Tahoma", 17F);
            this.lbManagePeople.ForeColor = System.Drawing.Color.Red;
            this.lbManagePeople.Location = new System.Drawing.Point(223, 182);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(350, 28);
            this.lbManagePeople.TabIndex = 17;
            this.lbManagePeople.Text = "Local Driving License Applications";
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetails,
            this.EditApplication,
            this.DeleteApp,
            this.CancelApp,
            this.ScheduleTest,
            this.IssueDriving,
            this.ShowLicense,
            this.ShoHistory});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsApplications.Size = new System.Drawing.Size(307, 330);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // showDetails
            // 
            this.showDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.showDetails.Image = ((System.Drawing.Image)(resources.GetObject("showDetails.Image")));
            this.showDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetails.Name = "showDetails";
            this.showDetails.Size = new System.Drawing.Size(306, 38);
            this.showDetails.Text = "Show Applications Details";
            // 
            // EditApplication
            // 
            this.EditApplication.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.EditApplication.Image = ((System.Drawing.Image)(resources.GetObject("EditApplication.Image")));
            this.EditApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditApplication.Name = "EditApplication";
            this.EditApplication.Size = new System.Drawing.Size(306, 38);
            this.EditApplication.Text = "Edit Application";
            this.EditApplication.Click += new System.EventHandler(this.EditApplication_Click);
            // 
            // DeleteApp
            // 
            this.DeleteApp.Image = ((System.Drawing.Image)(resources.GetObject("DeleteApp.Image")));
            this.DeleteApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteApp.Name = "DeleteApp";
            this.DeleteApp.Size = new System.Drawing.Size(306, 38);
            this.DeleteApp.Text = "Delete Application";
            this.DeleteApp.Click += new System.EventHandler(this.DeleteApp_Click);
            // 
            // CancelApp
            // 
            this.CancelApp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CancelApp.Image = global::project19.Properties.Resources.Delete_32;
            this.CancelApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CancelApp.Name = "CancelApp";
            this.CancelApp.Size = new System.Drawing.Size(306, 38);
            this.CancelApp.Text = "Cancel Application";
            this.CancelApp.Click += new System.EventHandler(this.dalete_Click);
            // 
            // ScheduleTest
            // 
            this.ScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTest,
            this.WrittenTest,
            this.StreetTest});
            this.ScheduleTest.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ScheduleTest.Image = ((System.Drawing.Image)(resources.GetObject("ScheduleTest.Image")));
            this.ScheduleTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleTest.Name = "ScheduleTest";
            this.ScheduleTest.Size = new System.Drawing.Size(306, 38);
            this.ScheduleTest.Text = "Sechduel Test";
            this.ScheduleTest.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // visionTest
            // 
            this.visionTest.Image = ((System.Drawing.Image)(resources.GetObject("visionTest.Image")));
            this.visionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visionTest.Name = "visionTest";
            this.visionTest.Size = new System.Drawing.Size(237, 38);
            this.visionTest.Tag = "1";
            this.visionTest.Text = "SchduleTest Vision";
            this.visionTest.Click += new System.EventHandler(this.sechuleTestVisionToolStripMenuItem_Click);
            // 
            // WrittenTest
            // 
            this.WrittenTest.Image = ((System.Drawing.Image)(resources.GetObject("WrittenTest.Image")));
            this.WrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.WrittenTest.Name = "WrittenTest";
            this.WrittenTest.Size = new System.Drawing.Size(237, 38);
            this.WrittenTest.Tag = "2";
            this.WrittenTest.Text = "Sechdule Written Test";
            this.WrittenTest.Click += new System.EventHandler(this.WrittenTest_Click);
            // 
            // StreetTest
            // 
            this.StreetTest.Image = ((System.Drawing.Image)(resources.GetObject("StreetTest.Image")));
            this.StreetTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StreetTest.Name = "StreetTest";
            this.StreetTest.Size = new System.Drawing.Size(237, 38);
            this.StreetTest.Tag = "3";
            this.StreetTest.Text = "Schedule Street Test";
            this.StreetTest.Click += new System.EventHandler(this.StreetTest_Click);
            // 
            // IssueDriving
            // 
            this.IssueDriving.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.IssueDriving.Image = ((System.Drawing.Image)(resources.GetObject("IssueDriving.Image")));
            this.IssueDriving.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IssueDriving.Name = "IssueDriving";
            this.IssueDriving.Size = new System.Drawing.Size(306, 38);
            this.IssueDriving.Text = "Issue Driving License (First Time)";
            this.IssueDriving.Click += new System.EventHandler(this.IssueDriving_Click);
            // 
            // ShowLicense
            // 
            this.ShowLicense.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ShowLicense.Image = ((System.Drawing.Image)(resources.GetObject("ShowLicense.Image")));
            this.ShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.Size = new System.Drawing.Size(306, 38);
            this.ShowLicense.Text = "Show License";
            this.ShowLicense.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // ShoHistory
            // 
            this.ShoHistory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ShoHistory.Image = ((System.Drawing.Image)(resources.GetObject("ShoHistory.Image")));
            this.ShoHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShoHistory.Name = "ShoHistory";
            this.ShoHistory.Size = new System.Drawing.Size(306, 38);
            this.ShoHistory.Text = "Show Person License History";
            this.ShoHistory.Click += new System.EventHandler(this.ShoHistory_Click);
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowDrop = true;
            this.dgvApplications.AllowUserToOrderColumns = true;
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.ContextMenuStrip = this.cmsApplications;
            this.dgvApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvApplications.Location = new System.Drawing.Point(12, 300);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.Size = new System.Drawing.Size(883, 248);
            this.dgvApplications.TabIndex = 22;
            this.dgvApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplications_CellContentClick);
            this.dgvApplications.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvApplications_CellMouseDown);
            this.dgvApplications.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvApplications_MouseDown);
            // 
            // lbNumberRecords
            // 
            this.lbNumberRecords.AutoSize = true;
            this.lbNumberRecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNumberRecords.Location = new System.Drawing.Point(91, 571);
            this.lbNumberRecords.Name = "lbNumberRecords";
            this.lbNumberRecords.Size = new System.Drawing.Size(33, 19);
            this.lbNumberRecords.TabIndex = 26;
            this.lbNumberRecords.Text = "???";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbRecords.Location = new System.Drawing.Point(12, 571);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(83, 19);
            this.lbRecords.TabIndex = 25;
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
            this.btClose.Location = new System.Drawing.Point(776, 564);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 23;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(446, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btAddPerson
            // 
            this.btAddPerson.BackColor = System.Drawing.Color.White;
            this.btAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btAddPerson.Image")));
            this.btAddPerson.Location = new System.Drawing.Point(817, 219);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(78, 75);
            this.btAddPerson.TabIndex = 18;
            this.btAddPerson.Tag = "1";
            this.btAddPerson.UseVisualStyleBackColor = false;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.Image = ((System.Drawing.Image)(resources.GetObject("pbPeople.Image")));
            this.pbPeople.Location = new System.Drawing.Point(310, 25);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(149, 144);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 16;
            this.pbPeople.TabStop = false;
            // 
            // ctrFilterLocalDrivingApplications1
            // 
            this.ctrFilterLocalDrivingApplications1.FilterColumns = null;
            this.ctrFilterLocalDrivingApplications1.Location = new System.Drawing.Point(3, 219);
            this.ctrFilterLocalDrivingApplications1.Name = "ctrFilterLocalDrivingApplications1";
            this.ctrFilterLocalDrivingApplications1.Size = new System.Drawing.Size(430, 75);
            this.ctrFilterLocalDrivingApplications1.SourceData = null;
            this.ctrFilterLocalDrivingApplications1.TabIndex = 24;
            this.ctrFilterLocalDrivingApplications1.TargetGrid = null;
            this.ctrFilterLocalDrivingApplications1.OnFilterLocalApplications += new System.Action<string>(this.ctrFilterLocalDrivingApplications1_OnFilterLocalApplications);
            // 
            // frmManageApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 597);
            this.Controls.Add(this.lbNumberRecords);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.ctrFilterLocalDrivingApplications1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.lbManagePeople);
            this.Controls.Add(this.pbPeople);
            this.Name = "frmManageApplications";
            this.Text = "frmManageApplications";
            this.Load += new System.EventHandler(this.frmManageApplications_Load);
            this.cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem showDetails;
        private System.Windows.Forms.ToolStripMenuItem EditApplication;
        private System.Windows.Forms.ToolStripMenuItem DeleteApp;
        private System.Windows.Forms.ToolStripMenuItem CancelApp;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTest;
        private System.Windows.Forms.ToolStripMenuItem IssueDriving;
        private System.Windows.Forms.ToolStripMenuItem ShowLicense;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView dgvApplications;
        private ctrFilterLocalDrivingApplications ctrFilterLocalDrivingApplications1;
        private System.Windows.Forms.Label lbNumberRecords;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.ToolStripMenuItem visionTest;
        private System.Windows.Forms.ToolStripMenuItem WrittenTest;
        private System.Windows.Forms.ToolStripMenuItem StreetTest;
        private System.Windows.Forms.ToolStripMenuItem ShoHistory;
    }
}