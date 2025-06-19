namespace project19
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Currentuserinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.changePass = new System.Windows.Forms.ToolStripMenuItem();
            this.signOut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DriverSevers = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenewLicensApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.Repalcement = new System.Windows.Forms.ToolStripMenuItem();
            this.release = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrinvingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btDrivers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btAccountSetting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPeople = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Currentuserinfo,
            this.changePass,
            this.signOut});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 70);
            // 
            // Currentuserinfo
            // 
            this.Currentuserinfo.Image = ((System.Drawing.Image)(resources.GetObject("Currentuserinfo.Image")));
            this.Currentuserinfo.Name = "Currentuserinfo";
            this.Currentuserinfo.Size = new System.Drawing.Size(168, 22);
            this.Currentuserinfo.Text = "UserInfo";
            this.Currentuserinfo.Click += new System.EventHandler(this.Currentuserinfo_Click);
            // 
            // changePass
            // 
            this.changePass.Image = ((System.Drawing.Image)(resources.GetObject("changePass.Image")));
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(168, 22);
            this.changePass.Text = "Change Password";
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // signOut
            // 
            this.signOut.Image = ((System.Drawing.Image)(resources.GetObject("signOut.Image")));
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(168, 22);
            this.signOut.Text = "Sign Out";
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DriverSevers,
            this.toolStripMenuItem3,
            this.manageDetainToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.cmsApplications.Name = "cmsApplications";
            this.cmsApplications.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsApplications.Size = new System.Drawing.Size(330, 376);
            // 
            // DriverSevers
            // 
            this.DriverSevers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicensToolStripMenuItem,
            this.RenewLicensApplication,
            this.Repalcement,
            this.release,
            this.retakeTestToolStripMenuItem});
            this.DriverSevers.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.DriverSevers.Image = ((System.Drawing.Image)(resources.GetObject("DriverSevers.Image")));
            this.DriverSevers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DriverSevers.Name = "DriverSevers";
            this.DriverSevers.Size = new System.Drawing.Size(329, 70);
            this.DriverSevers.Text = "Driving License Services";
            // 
            // localLicensToolStripMenuItem
            // 
            this.localLicensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.localLicensToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localLicensToolStripMenuItem.Image")));
            this.localLicensToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localLicensToolStripMenuItem.Name = "localLicensToolStripMenuItem";
            this.localLicensToolStripMenuItem.Size = new System.Drawing.Size(455, 38);
            this.localLicensToolStripMenuItem.Text = "New Driving License";
            this.localLicensToolStripMenuItem.Click += new System.EventHandler(this.localLicensToolStripMenuItem_Click);
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localLicenseToolStripMenuItem.Image")));
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalLicenseToolStripMenuItem.Image")));
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // RenewLicensApplication
            // 
            this.RenewLicensApplication.Image = ((System.Drawing.Image)(resources.GetObject("RenewLicensApplication.Image")));
            this.RenewLicensApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RenewLicensApplication.Name = "RenewLicensApplication";
            this.RenewLicensApplication.Size = new System.Drawing.Size(455, 38);
            this.RenewLicensApplication.Text = "Renew License Application";
            this.RenewLicensApplication.Click += new System.EventHandler(this.RenewLicensApplication_Click);
            // 
            // Repalcement
            // 
            this.Repalcement.Image = ((System.Drawing.Image)(resources.GetObject("Repalcement.Image")));
            this.Repalcement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Repalcement.Name = "Repalcement";
            this.Repalcement.Size = new System.Drawing.Size(455, 38);
            this.Repalcement.Text = "Replacement For Lost or Damaged License";
            this.Repalcement.Click += new System.EventHandler(this.Repalcement_Click);
            // 
            // release
            // 
            this.release.Image = ((System.Drawing.Image)(resources.GetObject("release.Image")));
            this.release.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.release.Name = "release";
            this.release.Size = new System.Drawing.Size(455, 38);
            this.release.Text = "Release Detained Driving License ";
            this.release.Click += new System.EventHandler(this.release_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retakeTestToolStripMenuItem.Image")));
            this.retakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(455, 38);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.internationalDrinvingLicenseApplicationsToolStripMenuItem});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(329, 70);
            this.toolStripMenuItem3.Text = "Manage Applications";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(498, 38);
            this.toolStripMenuItem5.Text = "Local Driving License Applications";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // internationalDrinvingLicenseApplicationsToolStripMenuItem
            // 
            this.internationalDrinvingLicenseApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalDrinvingLicenseApplicationsToolStripMenuItem.Image")));
            this.internationalDrinvingLicenseApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalDrinvingLicenseApplicationsToolStripMenuItem.Name = "internationalDrinvingLicenseApplicationsToolStripMenuItem";
            this.internationalDrinvingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(498, 38);
            this.internationalDrinvingLicenseApplicationsToolStripMenuItem.Text = "International Drinving License Applications";
            this.internationalDrinvingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.internationalDrinvingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // manageDetainToolStripMenuItem
            // 
            this.manageDetainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem});
            this.manageDetainToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.manageDetainToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageDetainToolStripMenuItem.Image")));
            this.manageDetainToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageDetainToolStripMenuItem.Name = "manageDetainToolStripMenuItem";
            this.manageDetainToolStripMenuItem.Size = new System.Drawing.Size(329, 70);
            this.manageDetainToolStripMenuItem.Text = "Detained Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageDetainedLicensesToolStripMenuItem.Image")));
            this.manageDetainedLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(331, 38);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicenseToolStripMenuItem.Image")));
            this.detainLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(331, 38);
            this.detainLicenseToolStripMenuItem.Text = "Detain License ";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseLicenseToolStripMenuItem.Image")));
            this.releaseLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(331, 38);
            this.releaseLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(329, 70);
            this.toolStripMenuItem1.Text = "Manage Applications Type";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(329, 70);
            this.toolStripMenuItem2.Text = "Manage Test Types";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btDrivers
            // 
            this.btDrivers.BackColor = System.Drawing.Color.White;
            this.btDrivers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDrivers.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btDrivers.Image = ((System.Drawing.Image)(resources.GetObject("btDrivers.Image")));
            this.btDrivers.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btDrivers.Location = new System.Drawing.Point(313, 0);
            this.btDrivers.Name = "btDrivers";
            this.btDrivers.Size = new System.Drawing.Size(120, 75);
            this.btDrivers.TabIndex = 11;
            this.btDrivers.Text = "Drivers";
            this.btDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDrivers.UseVisualStyleBackColor = false;
            this.btDrivers.Click += new System.EventHandler(this.btDrivers_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ContextMenuStrip = this.cmsApplications;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 75);
            this.button2.TabIndex = 10;
            this.button2.Text = "Applications";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btAccountSetting
            // 
            this.btAccountSetting.BackColor = System.Drawing.Color.White;
            this.btAccountSetting.ContextMenuStrip = this.contextMenuStrip1;
            this.btAccountSetting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAccountSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAccountSetting.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btAccountSetting.Image = ((System.Drawing.Image)(resources.GetObject("btAccountSetting.Image")));
            this.btAccountSetting.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btAccountSetting.Location = new System.Drawing.Point(579, 0);
            this.btAccountSetting.Name = "btAccountSetting";
            this.btAccountSetting.Size = new System.Drawing.Size(187, 75);
            this.btAccountSetting.TabIndex = 9;
            this.btAccountSetting.Text = "Account Settings";
            this.btAccountSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAccountSetting.UseVisualStyleBackColor = false;
            this.btAccountSetting.Click += new System.EventHandler(this.btAccountSetting_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(453, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "Users";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1101, 625);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btPeople
            // 
            this.btPeople.BackColor = System.Drawing.Color.White;
            this.btPeople.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPeople.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btPeople.Image = ((System.Drawing.Image)(resources.GetObject("btPeople.Image")));
            this.btPeople.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btPeople.Location = new System.Drawing.Point(166, 0);
            this.btPeople.Name = "btPeople";
            this.btPeople.Size = new System.Drawing.Size(120, 75);
            this.btPeople.TabIndex = 5;
            this.btPeople.Text = "People";
            this.btPeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPeople.UseVisualStyleBackColor = false;
            this.btPeople.Click += new System.EventHandler(this.btPeople_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 642);
            this.Controls.Add(this.btDrivers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btAccountSetting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btPeople);
            this.Name = "frmMain";
            this.Text = "rfmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Currentuserinfo;
        private System.Windows.Forms.ToolStripMenuItem changePass;
        private System.Windows.Forms.ToolStripMenuItem signOut;
        private System.Windows.Forms.Button btAccountSetting;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem DriverSevers;
        private System.Windows.Forms.Button btDrivers;
        private System.Windows.Forms.ToolStripMenuItem localLicensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrinvingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenewLicensApplication;
        private System.Windows.Forms.ToolStripMenuItem Repalcement;
        private System.Windows.Forms.ToolStripMenuItem release;
        private System.Windows.Forms.ToolStripMenuItem manageDetainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
    }
}