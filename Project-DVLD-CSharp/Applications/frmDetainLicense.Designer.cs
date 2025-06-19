namespace project19.Applications
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            this.ctrInternationalLicense1 = new project19.ctrInternationalLicense();
            this.ctrDetainedLicenseInfo1 = new project19.Applications.ctrDetainedLicenseInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblinkShowLHistory = new System.Windows.Forms.LinkLabel();
            this.lbkShowLicense = new System.Windows.Forms.LinkLabel();
            this.btClose = new System.Windows.Forms.Button();
            this.btDetain = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrInternationalLicense1
            // 
            this.ctrInternationalLicense1.Location = new System.Drawing.Point(24, 3);
            this.ctrInternationalLicense1.Name = "ctrInternationalLicense1";
            this.ctrInternationalLicense1.Size = new System.Drawing.Size(853, 449);
            this.ctrInternationalLicense1.TabIndex = 0;
            this.ctrInternationalLicense1.OnLicenseID += new System.Action<int>(this.ctrInternationalLicense1_OnLicenseID);
            this.ctrInternationalLicense1.Load += new System.EventHandler(this.ctrInternationalLicense1_Load);
            // 
            // ctrDetainedLicenseInfo1
            // 
            this.ctrDetainedLicenseInfo1.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.ctrDetainedLicenseInfo1.Location = new System.Drawing.Point(13, 18);
            this.ctrDetainedLicenseInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrDetainedLicenseInfo1.Name = "ctrDetainedLicenseInfo1";
            this.ctrDetainedLicenseInfo1.Size = new System.Drawing.Size(840, 155);
            this.ctrDetainedLicenseInfo1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrDetainedLicenseInfo1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(24, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            // 
            // lblinkShowLHistory
            // 
            this.lblinkShowLHistory.AutoSize = true;
            this.lblinkShowLHistory.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblinkShowLHistory.Location = new System.Drawing.Point(683, 187);
            this.lblinkShowLHistory.Name = "lblinkShowLHistory";
            this.lblinkShowLHistory.Size = new System.Drawing.Size(144, 18);
            this.lblinkShowLHistory.TabIndex = 45;
            this.lblinkShowLHistory.TabStop = true;
            this.lblinkShowLHistory.Text = "Show License History";
            this.lblinkShowLHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblinkShowLHistory_LinkClicked);
            // 
            // lbkShowLicense
            // 
            this.lbkShowLicense.AutoSize = true;
            this.lbkShowLicense.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbkShowLicense.Location = new System.Drawing.Point(683, 158);
            this.lbkShowLicense.Name = "lbkShowLicense";
            this.lbkShowLicense.Size = new System.Drawing.Size(159, 18);
            this.lbkShowLicense.TabIndex = 44;
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
            this.btClose.Location = new System.Drawing.Point(734, 644);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(86, 36);
            this.btClose.TabIndex = 43;
            this.btClose.Text = "     Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDetain
            // 
            this.btDetain.BackColor = System.Drawing.Color.White;
            this.btDetain.FlatAppearance.BorderSize = 2;
            this.btDetain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDetain.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btDetain.Image = ((System.Drawing.Image)(resources.GetObject("btDetain.Image")));
            this.btDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDetain.Location = new System.Drawing.Point(843, 644);
            this.btDetain.Name = "btDetain";
            this.btDetain.Size = new System.Drawing.Size(88, 36);
            this.btDetain.TabIndex = 42;
            this.btDetain.Text = "Detain";
            this.btDetain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDetain.UseVisualStyleBackColor = false;
            this.btDetain.Click += new System.EventHandler(this.btDetain_Click);
            //this.btDetain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btDetain_MouseClick);
            //this.btDetain.Validating += new System.ComponentModel.CancelEventHandler(this.btDetain_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 681);
            this.Controls.Add(this.lblinkShowLHistory);
            this.Controls.Add(this.lbkShowLicense);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDetain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrInternationalLicense1);
            this.Name = "frmDetainLicense";
            this.Text = "frmDetainLicense";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            //this.Leave += new System.EventHandler(this.frmDetainLicense_Leave);
            //this.Validating += new System.ComponentModel.CancelEventHandler(this.frmDetainLicense_Validating);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrInternationalLicense ctrInternationalLicense1;
        private ctrDetainedLicenseInfo ctrDetainedLicenseInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lblinkShowLHistory;
        private System.Windows.Forms.LinkLabel lbkShowLicense;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btDetain;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}