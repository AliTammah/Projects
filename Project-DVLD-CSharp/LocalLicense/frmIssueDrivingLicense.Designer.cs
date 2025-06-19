namespace project19
{
    partial class frmIssueDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDrivingLicense));
            this.ctrDrivingLicenseApplicationInfo1 = new project19.ctrDrivingLicenseApplicationInfo();
            this.ctrApplicationsBasicInfo1 = new project19.ctrApplicationsBasicInfo();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNotes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrDrivingLicenseApplicationInfo1
            // 
            this.ctrDrivingLicenseApplicationInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrDrivingLicenseApplicationInfo1.Name = "ctrDrivingLicenseApplicationInfo1";
            this.ctrDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(747, 112);
            this.ctrDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // ctrApplicationsBasicInfo1
            // 
            this.ctrApplicationsBasicInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrApplicationsBasicInfo1.Location = new System.Drawing.Point(12, 130);
            this.ctrApplicationsBasicInfo1.Name = "ctrApplicationsBasicInfo1";
            this.ctrApplicationsBasicInfo1.Size = new System.Drawing.Size(751, 241);
            this.ctrApplicationsBasicInfo1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 377);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(675, 76);
            this.textBox1.TabIndex = 2;
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNotes.Location = new System.Drawing.Point(9, 380);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(55, 19);
            this.lbNotes.TabIndex = 3;
            this.lbNotes.Text = "Notes:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 33);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(485, 459);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(130, 36);
            this.btClose.TabIndex = 28;
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
            this.btSave.Location = new System.Drawing.Point(644, 459);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(129, 36);
            this.btSave.TabIndex = 27;
            this.btSave.Text = "Issue";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmIssueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 498);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ctrApplicationsBasicInfo1);
            this.Controls.Add(this.ctrDrivingLicenseApplicationInfo1);
            this.Name = "frmIssueDrivingLicense";
            this.Text = "frmIssueDrivingLicense";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrDrivingLicenseApplicationInfo ctrDrivingLicenseApplicationInfo1;
        private ctrApplicationsBasicInfo ctrApplicationsBasicInfo1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
    }
}