namespace project19
{
    partial class ctrInternationalLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrInternationalLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.gbDLInfo = new System.Windows.Forms.GroupBox();
            this.ctrLicenseInfo2 = new project19.ctrLicenseInfo();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.ctrLicenseInfo1 = new project19.ctrLicenseInfo();
            this.gbDLInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "International License Application";
            // 
            // gbDLInfo
            // 
            this.gbDLInfo.Controls.Add(this.ctrLicenseInfo2);
            this.gbDLInfo.Location = new System.Drawing.Point(18, 117);
            this.gbDLInfo.Name = "gbDLInfo";
            this.gbDLInfo.Size = new System.Drawing.Size(847, 305);
            this.gbDLInfo.TabIndex = 2;
            this.gbDLInfo.TabStop = false;
            this.gbDLInfo.Text = "Driver License Info";
            this.gbDLInfo.Enter += new System.EventHandler(this.gbDLInfo_Enter);
            // 
            // ctrLicenseInfo2
            // 
            this.ctrLicenseInfo2.Location = new System.Drawing.Point(6, 19);
            this.ctrLicenseInfo2.Name = "ctrLicenseInfo2";
            this.ctrLicenseInfo2.Size = new System.Drawing.Size(847, 300);
            this.ctrLicenseInfo2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFind);
            this.groupBox2.Location = new System.Drawing.Point(199, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(414, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 41);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "LicenseID:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(110, 28);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(270, 27);
            this.txtFind.TabIndex = 0;
            //this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // ctrLicenseInfo1
            // 
            this.ctrLicenseInfo1.Location = new System.Drawing.Point(0, 20);
            this.ctrLicenseInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrLicenseInfo1.Name = "ctrLicenseInfo1";
            this.ctrLicenseInfo1.Size = new System.Drawing.Size(826, 312);
            this.ctrLicenseInfo1.TabIndex = 0;
            this.ctrLicenseInfo1.Load += new System.EventHandler(this.ctrLicenseInfo1_Load);
            // 
            // ctrInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDLInfo);
            this.Controls.Add(this.label1);
            this.Name = "ctrInternationalLicense";
            this.Size = new System.Drawing.Size(896, 455);
            this.Load += new System.EventHandler(this.ctrInternationalLicense_Load);
            this.gbDLInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDLInfo;
        private ctrLicenseInfo ctrLicenseInfo1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFind;
        private ctrLicenseInfo ctrLicenseInfo2;
        private System.Windows.Forms.Button button1;
    }
}
