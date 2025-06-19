namespace project19.Applications
{
    partial class frmRenewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLicense));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrApplicationNewLicenseInfo1 = new project19.Applications.ctrApplicationNewLicenseInfo();
            this.lblinkShowLHistory = new System.Windows.Forms.LinkLabel();
            this.lbkShowLicense = new System.Windows.Forms.LinkLabel();
            this.btClose = new System.Windows.Forms.Button();
            this.btRenew = new System.Windows.Forms.Button();
            this.ctrInternationalLicense1 = new project19.ctrInternationalLicense();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrApplicationNewLicenseInfo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application New license Info:";
            // 
            // ctrApplicationNewLicenseInfo1
            // 
            this.ctrApplicationNewLicenseInfo1.Location = new System.Drawing.Point(6, 15);
            this.ctrApplicationNewLicenseInfo1.Name = "ctrApplicationNewLicenseInfo1";
            this.ctrApplicationNewLicenseInfo1.Size = new System.Drawing.Size(833, 237);
            this.ctrApplicationNewLicenseInfo1.TabIndex = 0;
            this.ctrApplicationNewLicenseInfo1.Load += new System.EventHandler(this.ctrApplicationNewLicenseInfo1_Load);
            // 
            // lblinkShowLHistory
            // 
            this.lblinkShowLHistory.AutoSize = true;
            this.lblinkShowLHistory.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblinkShowLHistory.Location = new System.Drawing.Point(44, 707);
            this.lblinkShowLHistory.Name = "lblinkShowLHistory";
            this.lblinkShowLHistory.Size = new System.Drawing.Size(144, 18);
            this.lblinkShowLHistory.TabIndex = 37;
            this.lblinkShowLHistory.TabStop = true;
            this.lblinkShowLHistory.Text = "Show License History";
            this.lblinkShowLHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lbkShowLicense
            // 
            this.lbkShowLicense.AutoSize = true;
            this.lbkShowLicense.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbkShowLicense.Location = new System.Drawing.Point(213, 707);
            this.lbkShowLicense.Name = "lbkShowLicense";
            this.lbkShowLicense.Size = new System.Drawing.Size(126, 18);
            this.lbkShowLicense.TabIndex = 36;
            this.lbkShowLicense.TabStop = true;
            this.lbkShowLicense.Text = "Show License Info";
            this.lbkShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkShowLicense_LinkClicked);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(612, 700);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(130, 36);
            this.btClose.TabIndex = 35;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btRenew
            // 
            this.btRenew.BackColor = System.Drawing.Color.White;
            this.btRenew.FlatAppearance.BorderSize = 2;
            this.btRenew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRenew.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btRenew.Image = ((System.Drawing.Image)(resources.GetObject("btRenew.Image")));
            this.btRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRenew.Location = new System.Drawing.Point(779, 700);
            this.btRenew.Name = "btRenew";
            this.btRenew.Size = new System.Drawing.Size(129, 36);
            this.btRenew.TabIndex = 34;
            this.btRenew.Text = "Renew";
            this.btRenew.UseVisualStyleBackColor = false;
            this.btRenew.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ctrInternationalLicense1
            // 
            this.ctrInternationalLicense1.BackColor = System.Drawing.Color.White;
            this.ctrInternationalLicense1.Location = new System.Drawing.Point(12, 0);
            this.ctrInternationalLicense1.Name = "ctrInternationalLicense1";
            this.ctrInternationalLicense1.Size = new System.Drawing.Size(896, 430);
            this.ctrInternationalLicense1.TabIndex = 0;
            this.ctrInternationalLicense1.OnLicenseID += new System.Action<int>(this.ctrInternationalLicense1_OnLicenseID);
            // 
            // frmRenewLicense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(927, 743);
            this.Controls.Add(this.lblinkShowLHistory);
            this.Controls.Add(this.lbkShowLicense);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btRenew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrInternationalLicense1);
            this.Name = "frmRenewLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenewLicense";
            this.Load += new System.EventHandler(this.frmRenewLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrInternationalLicense ctrInternationalLicense1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ctrApplicationNewLicenseInfo ctrApplicationNewLicenseInfo1;
        private System.Windows.Forms.LinkLabel lblinkShowLHistory;
        private System.Windows.Forms.LinkLabel lbkShowLicense;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btRenew;
    }
}