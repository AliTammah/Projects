namespace project19
{
    partial class frmShowInfoUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowInfoUsers));
            this.ctrLoginInfromation1 = new project19.ctrLoginInfromation();
            this.ctrInfoPerson1 = new project19.ctrInfoPerson();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrLoginInfromation1
            // 
            this.ctrLoginInfromation1.BackColor = System.Drawing.Color.White;
            this.ctrLoginInfromation1.Location = new System.Drawing.Point(39, 337);
            this.ctrLoginInfromation1.Name = "ctrLoginInfromation1";
            this.ctrLoginInfromation1.Size = new System.Drawing.Size(756, 75);
            this.ctrLoginInfromation1.TabIndex = 0;
            // 
            // ctrInfoPerson1
            // 
            this.ctrInfoPerson1.Location = new System.Drawing.Point(33, 50);
            this.ctrInfoPerson1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrInfoPerson1.Name = "ctrInfoPerson1";
            this.ctrInfoPerson1.Size = new System.Drawing.Size(772, 264);
            this.ctrInfoPerson1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personal Infromation";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(724, 446);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 15;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmShowInfoUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 494);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrInfoPerson1);
            this.Controls.Add(this.ctrLoginInfromation1);
            this.Name = "frmShowInfoUsers";
            this.Text = "frmShowInfoUsers";
            this.Load += new System.EventHandler(this.frmShowInfoUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrLoginInfromation ctrLoginInfromation1;
        private ctrInfoPerson ctrInfoPerson1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
    }
}