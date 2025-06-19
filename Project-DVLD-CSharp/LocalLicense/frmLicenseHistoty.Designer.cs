namespace project19
{
    partial class frmLicenseHistoty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseHistoty));
            this.ctrAddUpdateUser1 = new project19.ctrAddUpdateUser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumberRecords = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrLicenseHistory1 = new project19.ctrLicenseHistory();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrAddUpdateUser1
            // 
            this.ctrAddUpdateUser1.BackColor = System.Drawing.Color.White;
            this.ctrAddUpdateUser1.Location = new System.Drawing.Point(167, 54);
            this.ctrAddUpdateUser1.Name = "ctrAddUpdateUser1";
            this.ctrAddUpdateUser1.Size = new System.Drawing.Size(739, 326);
            this.ctrAddUpdateUser1.TabIndex = 0;
            this.ctrAddUpdateUser1.Load += new System.EventHandler(this.ctrAddUpdateUser1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "License History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(195, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Person Infromation\r\n";
            // 
            // lbNumberRecords
            // 
            this.lbNumberRecords.AutoSize = true;
            this.lbNumberRecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNumberRecords.Location = new System.Drawing.Point(98, 613);
            this.lbNumberRecords.Name = "lbNumberRecords";
            this.lbNumberRecords.Size = new System.Drawing.Size(33, 19);
            this.lbNumberRecords.TabIndex = 29;
            this.lbNumberRecords.Text = "???";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbRecords.Location = new System.Drawing.Point(9, 610);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(83, 19);
            this.lbRecords.TabIndex = 28;
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
            this.btClose.Location = new System.Drawing.Point(812, 605);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 27;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ctrLicenseHistory1
            // 
            this.ctrLicenseHistory1.Location = new System.Drawing.Point(13, 386);
            this.ctrLicenseHistory1.Name = "ctrLicenseHistory1";
            this.ctrLicenseHistory1.Size = new System.Drawing.Size(872, 207);
            this.ctrLicenseHistory1.TabIndex = 30;
            this.ctrLicenseHistory1.Load += new System.EventHandler(this.ctrLicenseHistory1_Load);
            // 
            // frmLicenseHistoty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 638);
            this.Controls.Add(this.ctrLicenseHistory1);
            this.Controls.Add(this.lbNumberRecords);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrAddUpdateUser1);
            this.Name = "frmLicenseHistoty";
            this.Text = "frmLicenseHistoty";
            this.Load += new System.EventHandler(this.frmLicenseHistoty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrAddUpdateUser ctrAddUpdateUser1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNumberRecords;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btClose;
        private ctrLicenseHistory ctrLicenseHistory1;
    }
}