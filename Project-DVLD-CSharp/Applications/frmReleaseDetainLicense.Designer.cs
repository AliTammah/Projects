namespace project19.Applications
{
    partial class frmReleaseDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReleaseDetainLicense));
            this.ctrInternationalLicense1 = new project19.ctrInternationalLicense();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrReleaseDetainLicense1 = new project19.Applications.ctrReleaseDetainLicense();
            this.lblinkShowLHistory = new System.Windows.Forms.LinkLabel();
            this.btClose = new System.Windows.Forms.Button();
            this.btRelease = new System.Windows.Forms.Button();
            this.lbkShowLicense = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrInternationalLicense1
            // 
            this.ctrInternationalLicense1.BackColor = System.Drawing.Color.White;
            this.ctrInternationalLicense1.Location = new System.Drawing.Point(24, 12);
            this.ctrInternationalLicense1.Name = "ctrInternationalLicense1";
            this.ctrInternationalLicense1.Size = new System.Drawing.Size(846, 455);
            this.ctrInternationalLicense1.TabIndex = 0;
            this.ctrInternationalLicense1.OnLicenseID += new System.Action<int>(this.ctrInternationalLicense1_OnLicenseID);
            this.ctrInternationalLicense1.Load += new System.EventHandler(this.ctrInternationalLicense1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.ctrReleaseDetainLicense1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(24, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Release Detain Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ctrReleaseDetainLicense1
            // 
            this.ctrReleaseDetainLicense1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrReleaseDetainLicense1.Location = new System.Drawing.Point(16, 24);
            this.ctrReleaseDetainLicense1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrReleaseDetainLicense1.Name = "ctrReleaseDetainLicense1";
            this.ctrReleaseDetainLicense1.Size = new System.Drawing.Size(756, 202);
            this.ctrReleaseDetainLicense1.TabIndex = 0;
            // 
            // lblinkShowLHistory
            // 
            this.lblinkShowLHistory.AutoSize = true;
            this.lblinkShowLHistory.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblinkShowLHistory.Location = new System.Drawing.Point(714, 193);
            this.lblinkShowLHistory.Name = "lblinkShowLHistory";
            this.lblinkShowLHistory.Size = new System.Drawing.Size(144, 18);
            this.lblinkShowLHistory.TabIndex = 49;
            this.lblinkShowLHistory.TabStop = true;
            this.lblinkShowLHistory.Text = "Show License History";
            this.lblinkShowLHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblinkShowLHistory_LinkClicked);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(687, 714);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(86, 36);
            this.btClose.TabIndex = 47;
            this.btClose.Text = "     Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btRelease
            // 
            this.btRelease.BackColor = System.Drawing.Color.White;
            this.btRelease.FlatAppearance.BorderSize = 2;
            this.btRelease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRelease.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btRelease.Image = ((System.Drawing.Image)(resources.GetObject("btRelease.Image")));
            this.btRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelease.Location = new System.Drawing.Point(790, 714);
            this.btRelease.Name = "btRelease";
            this.btRelease.Size = new System.Drawing.Size(99, 36);
            this.btRelease.TabIndex = 46;
            this.btRelease.Text = "Release";
            this.btRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRelease.UseVisualStyleBackColor = false;
            this.btRelease.Click += new System.EventHandler(this.btDetain_Click);
            // 
            // lbkShowLicense
            // 
            this.lbkShowLicense.AutoSize = true;
            this.lbkShowLicense.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbkShowLicense.Location = new System.Drawing.Point(701, 164);
            this.lbkShowLicense.Name = "lbkShowLicense";
            this.lbkShowLicense.Size = new System.Drawing.Size(169, 18);
            this.lbkShowLicense.TabIndex = 50;
            this.lbkShowLicense.TabStop = true;
            this.lbkShowLicense.Text = "Show New  License Info ";
            this.lbkShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkShowLicense_LinkClicked);
            // 
            // frmReleaseDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 749);
            this.Controls.Add(this.lbkShowLicense);
            this.Controls.Add(this.lblinkShowLHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrInternationalLicense1);
            this.Controls.Add(this.btRelease);
            this.Controls.Add(this.btClose);
            this.Name = "frmReleaseDetainLicense";
            this.Text = "frmReleaseDetainLicense";
            this.Load += new System.EventHandler(this.frmReleaseDetainLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrInternationalLicense ctrInternationalLicense1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ctrReleaseDetainLicense ctrReleaseDetainLicense1;
        private System.Windows.Forms.LinkLabel lblinkShowLHistory;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btRelease;
        private System.Windows.Forms.LinkLabel lbkShowLicense;
    }
}