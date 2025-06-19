namespace project19
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            this.tabPersonInfo = new System.Windows.Forms.TabControl();
            this.PersonalInfo = new System.Windows.Forms.TabPage();
            this.btNext = new System.Windows.Forms.Button();
            this.LoginInfo = new System.Windows.Forms.TabPage();
            this.lbAddUser = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.ctrAddUpdateUser1 = new project19.ctrAddUpdateUser();
            this.ctrLoginInfo1 = new project19.ctrLoginInfo();
            this.tabPersonInfo.SuspendLayout();
            this.PersonalInfo.SuspendLayout();
            this.LoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.Controls.Add(this.PersonalInfo);
            this.tabPersonInfo.Controls.Add(this.LoginInfo);
            this.tabPersonInfo.Location = new System.Drawing.Point(12, 77);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.SelectedIndex = 0;
            this.tabPersonInfo.Size = new System.Drawing.Size(877, 384);
            this.tabPersonInfo.TabIndex = 0;
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.Controls.Add(this.btNext);
            this.PersonalInfo.Controls.Add(this.ctrAddUpdateUser1);
            this.PersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalInfo.Size = new System.Drawing.Size(869, 358);
            this.PersonalInfo.TabIndex = 0;
            this.PersonalInfo.Text = "Personal Info";
            this.PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNext.Location = new System.Drawing.Point(775, 320);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(88, 32);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "Next";
            this.btNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // LoginInfo
            // 
            this.LoginInfo.Controls.Add(this.ctrLoginInfo1);
            this.LoginInfo.Location = new System.Drawing.Point(4, 22);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.LoginInfo.Size = new System.Drawing.Size(869, 358);
            this.LoginInfo.TabIndex = 1;
            this.LoginInfo.Text = "LoginInfo";
            this.LoginInfo.UseVisualStyleBackColor = true;
            // 
            // lbAddUser
            // 
            this.lbAddUser.AutoSize = true;
            this.lbAddUser.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.lbAddUser.ForeColor = System.Drawing.Color.Red;
            this.lbAddUser.Location = new System.Drawing.Point(346, 18);
            this.lbAddUser.Name = "lbAddUser";
            this.lbAddUser.Size = new System.Drawing.Size(175, 28);
            this.lbAddUser.TabIndex = 1;
            this.lbAddUser.Text = "Add New User";
            this.lbAddUser.Click += new System.EventHandler(this.lbAddUser_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(622, 467);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 5;
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
            this.btSave.Location = new System.Drawing.Point(765, 467);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 36);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "   Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ctrAddUpdateUser1
            // 
            this.ctrAddUpdateUser1.BackColor = System.Drawing.Color.White;
            this.ctrAddUpdateUser1.Location = new System.Drawing.Point(16, 6);
            this.ctrAddUpdateUser1.Name = "ctrAddUpdateUser1";
            this.ctrAddUpdateUser1.Size = new System.Drawing.Size(739, 326);
            this.ctrAddUpdateUser1.TabIndex = 0;
            this.ctrAddUpdateUser1.Load += new System.EventHandler(this.ctrAddUpdateUser1_Load_1);
            // 
            // ctrLoginInfo1
            // 
            this.ctrLoginInfo1.Location = new System.Drawing.Point(39, 50);
            this.ctrLoginInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrLoginInfo1.Name = "ctrLoginInfo1";
            this.ctrLoginInfo1.Size = new System.Drawing.Size(558, 291);
            this.ctrLoginInfo1.TabIndex = 0;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 515);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbAddUser);
            this.Controls.Add(this.tabPersonInfo);
            this.Name = "frmAddUpdateUser";
            this.Text = "frmAddUpdate";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.tabPersonInfo.ResumeLayout(false);
            this.PersonalInfo.ResumeLayout(false);
            this.LoginInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPersonInfo;
        private System.Windows.Forms.TabPage PersonalInfo;
        private System.Windows.Forms.TabPage LoginInfo;
        private ctrLoginInfo ctrLoginInfo1;
        private System.Windows.Forms.Label lbAddUser;
        private System.Windows.Forms.Button btNext;
        private ctrAddUpdateUser ctrAddUpdateUser1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
    }
}