namespace project19
{
    partial class frmAddUpdateInternational
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateInternational));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbkShowLicense = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.ctrInternationalLicense1 = new project19.ctrInternationalLicense();
            this.ctrLicenseApplicationInfo1 = new project19.ctrLicenseApplicationInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrLicenseApplicationInfo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // lbkShowLicense
            // 
            this.lbkShowLicense.AutoSize = true;
            this.lbkShowLicense.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbkShowLicense.Location = new System.Drawing.Point(212, 676);
            this.lbkShowLicense.Name = "lbkShowLicense";
            this.lbkShowLicense.Size = new System.Drawing.Size(126, 18);
            this.lbkShowLicense.TabIndex = 32;
            this.lbkShowLicense.TabStop = true;
            this.lbkShowLicense.Text = "Show License Info";
            this.lbkShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.linkLabel2.Location = new System.Drawing.Point(25, 675);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(144, 18);
            this.linkLabel2.TabIndex = 33;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Show License History";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(576, 657);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(130, 36);
            this.btClose.TabIndex = 30;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.FlatAppearance.BorderSize = 2;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(735, 657);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(129, 36);
            this.btSave.TabIndex = 29;
            this.btSave.Text = "Issue";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ctrInternationalLicense1
            // 
            this.ctrInternationalLicense1.BackColor = System.Drawing.Color.White;
            this.ctrInternationalLicense1.Location = new System.Drawing.Point(12, 12);
            this.ctrInternationalLicense1.Name = "ctrInternationalLicense1";
            this.ctrInternationalLicense1.Size = new System.Drawing.Size(861, 434);
            this.ctrInternationalLicense1.TabIndex = 31;
            this.ctrInternationalLicense1.OnLicenseID += new System.Action<int>(this.ctrInternationalLicense1_OnLicenseID);
            // 
            // ctrLicenseApplicationInfo1
            // 
            this.ctrLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrLicenseApplicationInfo1.Location = new System.Drawing.Point(6, 22);
            this.ctrLicenseApplicationInfo1.Name = "ctrLicenseApplicationInfo1";
            this.ctrLicenseApplicationInfo1.Size = new System.Drawing.Size(846, 154);
            this.ctrLicenseApplicationInfo1.TabIndex = 0;
            this.ctrLicenseApplicationInfo1.Load += new System.EventHandler(this.ctrLicenseApplicationInfo1_Load);
            // 
            // frmAddUpdateInternational
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 703);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lbkShowLicense);
            this.Controls.Add(this.ctrInternationalLicense1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddUpdateInternational";
            this.Text = "frmAddUpdateInternational";
            this.Load += new System.EventHandler(this.frmAddUpdateInternational_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrLicenseApplicationInfo ctrLicenseApplicationInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private ctrInternationalLicense ctrInternationalLicense1;
        private System.Windows.Forms.LinkLabel lbkShowLicense;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}