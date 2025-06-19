namespace project19
{
    partial class frmPersonDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonDetails));
            this.ctrInfoPerson1 = new project19.ctrInfoPerson();
            this.lbPersonDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrInfoPerson1
            // 
            this.ctrInfoPerson1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrInfoPerson1.Location = new System.Drawing.Point(24, 61);
            this.ctrInfoPerson1.Name = "ctrInfoPerson1";
            this.ctrInfoPerson1.Size = new System.Drawing.Size(732, 247);
            this.ctrInfoPerson1.TabIndex = 0;
            // 
            // lbPersonDetails
            // 
            this.lbPersonDetails.AutoSize = true;
            this.lbPersonDetails.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbPersonDetails.ForeColor = System.Drawing.Color.Red;
            this.lbPersonDetails.Location = new System.Drawing.Point(283, 9);
            this.lbPersonDetails.Name = "lbPersonDetails";
            this.lbPersonDetails.Size = new System.Drawing.Size(183, 33);
            this.lbPersonDetails.TabIndex = 1;
            this.lbPersonDetails.Text = "Person Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person Details";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(637, 314);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 348);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPersonDetails);
            this.Controls.Add(this.ctrInfoPerson1);
            this.Name = "frmPersonDetails";
            this.Text = "frmPersonDetails";
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrInfoPerson ctrInfoPerson1;
        private System.Windows.Forms.Label lbPersonDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
    }
}