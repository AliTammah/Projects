namespace project19
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lbCurPass = new System.Windows.Forms.Label();
            this.lbConfrmPass = new System.Windows.Forms.Label();
            this.lbNPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.ctrLoginInfromation1 = new project19.ctrLoginInfromation();
            this.ctrInfoPerson1 = new project19.ctrInfoPerson();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personal Infromation";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(282, 472);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(155, 20);
            this.txtNewPass.TabIndex = 3;
            this.txtNewPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPass_Validating);
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(282, 430);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(155, 20);
            this.txtCurrentPass.TabIndex = 4;
            this.txtCurrentPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPass_Validating);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(282, 511);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(155, 20);
            this.txtConfirmPass.TabIndex = 5;
            this.txtConfirmPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPass_Validating);
            // 
            // lbCurPass
            // 
            this.lbCurPass.AutoSize = true;
            this.lbCurPass.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbCurPass.Location = new System.Drawing.Point(50, 430);
            this.lbCurPass.Name = "lbCurPass";
            this.lbCurPass.Size = new System.Drawing.Size(164, 23);
            this.lbCurPass.TabIndex = 6;
            this.lbCurPass.Text = "Current Password:";
            // 
            // lbConfrmPass
            // 
            this.lbConfrmPass.AutoSize = true;
            this.lbConfrmPass.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbConfrmPass.Location = new System.Drawing.Point(48, 506);
            this.lbConfrmPass.Name = "lbConfrmPass";
            this.lbConfrmPass.Size = new System.Drawing.Size(166, 23);
            this.lbConfrmPass.TabIndex = 7;
            this.lbConfrmPass.Text = "Confirm Password:";
            // 
            // lbNPass
            // 
            this.lbNPass.AutoSize = true;
            this.lbNPass.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbNPass.Location = new System.Drawing.Point(76, 467);
            this.lbNPass.Name = "lbNPass";
            this.lbNPass.Size = new System.Drawing.Size(138, 23);
            this.lbNPass.TabIndex = 8;
            this.lbNPass.Text = "New Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(229, 511);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(229, 467);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(510, 573);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 13;
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
            this.btSave.Location = new System.Drawing.Point(653, 573);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 36);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "   Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ctrLoginInfromation1
            // 
            this.ctrLoginInfromation1.BackColor = System.Drawing.Color.White;
            this.ctrLoginInfromation1.Location = new System.Drawing.Point(26, 315);
            this.ctrLoginInfromation1.Name = "ctrLoginInfromation1";
            this.ctrLoginInfromation1.Size = new System.Drawing.Size(732, 75);
            this.ctrLoginInfromation1.TabIndex = 2;
            // 
            // ctrInfoPerson1
            // 
            this.ctrInfoPerson1.Location = new System.Drawing.Point(26, 34);
            this.ctrInfoPerson1.Name = "ctrInfoPerson1";
            this.ctrInfoPerson1.Size = new System.Drawing.Size(732, 247);
            this.ctrInfoPerson1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 621);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNPass);
            this.Controls.Add(this.lbConfrmPass);
            this.Controls.Add(this.lbCurPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.ctrLoginInfromation1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrInfoPerson1);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrInfoPerson ctrInfoPerson1;
        private System.Windows.Forms.Label label1;
        private ctrLoginInfromation ctrLoginInfromation1;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lbCurPass;
        private System.Windows.Forms.Label lbConfrmPass;
        private System.Windows.Forms.Label lbNPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}