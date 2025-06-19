namespace project19
{
    partial class frmAddUpdateTestAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateTestAppointments));
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.retakeTestInfo1 = new project19.RetakeTestInfo();
            this.ctrAddUpdateTestAppointments1 = new project19.ctrAddUpdateTestAppointments();
            this.ctrChangeProperties1 = new project19.ctrChangeProperties();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(295, 574);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(130, 36);
            this.btClose.TabIndex = 26;
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
            this.btSave.Location = new System.Drawing.Point(454, 574);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(129, 36);
            this.btSave.TabIndex = 25;
            this.btSave.Text = "   Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.retakeTestInfo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 117);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retake Test Info";
            // 
            // retakeTestInfo1
            // 
            this.retakeTestInfo1.Location = new System.Drawing.Point(7, 21);
            this.retakeTestInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.retakeTestInfo1.Name = "retakeTestInfo1";
            this.retakeTestInfo1.Size = new System.Drawing.Size(580, 89);
            this.retakeTestInfo1.TabIndex = 27;
            // 
            // ctrAddUpdateTestAppointments1
            // 
            this.ctrAddUpdateTestAppointments1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ctrAddUpdateTestAppointments1.Location = new System.Drawing.Point(12, 2);
            this.ctrAddUpdateTestAppointments1.Name = "ctrAddUpdateTestAppointments1";
            this.ctrAddUpdateTestAppointments1.Size = new System.Drawing.Size(554, 460);
            this.ctrAddUpdateTestAppointments1.TabIndex = 0;
            this.ctrAddUpdateTestAppointments1.Load += new System.EventHandler(this.ctrAddUpdateTestAppointments1_Load);
            // 
            // ctrChangeProperties1
            // 
            this.ctrChangeProperties1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrChangeProperties1.Location = new System.Drawing.Point(85, 2);
            this.ctrChangeProperties1.Name = "ctrChangeProperties1";
            this.ctrChangeProperties1.Size = new System.Drawing.Size(379, 150);
            this.ctrChangeProperties1.TabIndex = 29;
            // 
            // frmAddUpdateTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 613);
            this.Controls.Add(this.ctrChangeProperties1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.ctrAddUpdateTestAppointments1);
            this.Name = "frmAddUpdateTestAppointments";
            this.Text = "frmAddUpdateTestAppointments";
            this.Load += new System.EventHandler(this.frmAddUpdateTestAppointments_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrAddUpdateTestAppointments ctrAddUpdateTestAppointments1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private RetakeTestInfo retakeTestInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ctrChangeProperties ctrChangeProperties1;
    }
}