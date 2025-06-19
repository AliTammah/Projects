namespace project19.Applications
{
    partial class frmReplacementDamagedLostLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacementDamagedLostLicense));
            this.ctrInternationalLicense1 = new project19.ctrInternationalLicense();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrReplaceOrLostLicenseApp1 = new project19.Applications.ctrReplaceOrLostLicenseApp();
            this.lblinkShowLHistory = new System.Windows.Forms.LinkLabel();
            this.lbkShowLicense = new System.Windows.Forms.LinkLabel();
            this.btClose = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrInternationalLicense1
            // 
            this.ctrInternationalLicense1.BackColor = System.Drawing.Color.White;
            this.ctrInternationalLicense1.Location = new System.Drawing.Point(14, 12);
            this.ctrInternationalLicense1.Name = "ctrInternationalLicense1";
            this.ctrInternationalLicense1.Size = new System.Drawing.Size(841, 437);
            this.ctrInternationalLicense1.TabIndex = 0;
            this.ctrInternationalLicense1.OnLicenseID += new System.Action<int>(this.ctrInternationalLicense1_OnLicenseID);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.ctrReplaceOrLostLicenseApp1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox1.Location = new System.Drawing.Point(14, 482);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info for License Replacement";
            // 
            // ctrReplaceOrLostLicenseApp1
            // 
            this.ctrReplaceOrLostLicenseApp1.BackColor = System.Drawing.Color.White;
            this.ctrReplaceOrLostLicenseApp1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ctrReplaceOrLostLicenseApp1.Location = new System.Drawing.Point(7, 25);
            this.ctrReplaceOrLostLicenseApp1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrReplaceOrLostLicenseApp1.Name = "ctrReplaceOrLostLicenseApp1";
            this.ctrReplaceOrLostLicenseApp1.Size = new System.Drawing.Size(834, 113);
            this.ctrReplaceOrLostLicenseApp1.TabIndex = 0;
            // 
            // lblinkShowLHistory
            // 
            this.lblinkShowLHistory.AutoSize = true;
            this.lblinkShowLHistory.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblinkShowLHistory.Location = new System.Drawing.Point(13, 636);
            this.lblinkShowLHistory.Name = "lblinkShowLHistory";
            this.lblinkShowLHistory.Size = new System.Drawing.Size(144, 18);
            this.lblinkShowLHistory.TabIndex = 41;
            this.lblinkShowLHistory.TabStop = true;
            this.lblinkShowLHistory.Text = "Show License History";
            this.lblinkShowLHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblinkShowLHistory_LinkClicked);
            // 
            // lbkShowLicense
            // 
            this.lbkShowLicense.AutoSize = true;
            this.lbkShowLicense.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbkShowLicense.Location = new System.Drawing.Point(182, 636);
            this.lbkShowLicense.Name = "lbkShowLicense";
            this.lbkShowLicense.Size = new System.Drawing.Size(159, 18);
            this.lbkShowLicense.TabIndex = 40;
            this.lbkShowLicense.TabStop = true;
            this.lbkShowLicense.Text = "Show New License Info";
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
            this.btClose.Location = new System.Drawing.Point(480, 627);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(130, 36);
            this.btClose.TabIndex = 39;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btReplace
            // 
            this.btReplace.BackColor = System.Drawing.Color.White;
            this.btReplace.FlatAppearance.BorderSize = 2;
            this.btReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btReplace.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btReplace.Image = ((System.Drawing.Image)(resources.GetObject("btReplace.Image")));
            this.btReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReplace.Location = new System.Drawing.Point(629, 627);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(238, 36);
            this.btReplace.TabIndex = 38;
            this.btReplace.Text = "Issue Replacement ";
            this.btReplace.UseVisualStyleBackColor = false;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(279, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(368, 33);
            this.lbTitle.TabIndex = 42;
            this.lbTitle.Text = "Replacement Damage License";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rbLost);
            this.groupBox2.Controls.Add(this.rbDamaged);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(705, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 74);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replace ment For";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Font = new System.Drawing.Font("Tahoma", 8F);
            this.rbLost.Location = new System.Drawing.Point(6, 47);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(83, 17);
            this.rbLost.TabIndex = 1;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost License";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Font = new System.Drawing.Font("Tahoma", 8F);
            this.rbDamaged.Location = new System.Drawing.Point(6, 23);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(111, 17);
            this.rbDamaged.TabIndex = 0;
            this.rbDamaged.TabStop = true;
            this.rbDamaged.Text = "Damaged  License";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // frmReplacementDamagedLostLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lblinkShowLHistory);
            this.Controls.Add(this.lbkShowLicense);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrInternationalLicense1);
            this.Name = "frmReplacementDamagedLostLicense";
            this.Text = "frmReplacementDamagedLostLicense";
            this.Load += new System.EventHandler(this.frmReplacementDamagedLostLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrInternationalLicense ctrInternationalLicense1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ctrReplaceOrLostLicenseApp ctrReplaceOrLostLicenseApp1;
        private System.Windows.Forms.LinkLabel lblinkShowLHistory;
        private System.Windows.Forms.LinkLabel lbkShowLicense;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.RadioButton rbLost;
    }
}