namespace project19
{
    partial class ctrAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrAddUpdateUser));
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.lbFind = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbAddUser = new System.Windows.Forms.PictureBox();
            this.ctrInfoPerson1 = new project19.ctrInfoPerson();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(256, 19);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(177, 27);
            this.txtFind.TabIndex = 5;
            // 
            // cbFind
            // 
            this.cbFind.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Location = new System.Drawing.Point(81, 19);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(160, 27);
            this.cbFind.TabIndex = 4;
            this.cbFind.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbFind.Location = new System.Drawing.Point(3, 22);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(67, 19);
            this.lbFind.TabIndex = 3;
            this.lbFind.Text = "Find By:";
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(448, 16);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(40, 30);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 6;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbAddUser
            // 
            this.pbAddUser.Image = ((System.Drawing.Image)(resources.GetObject("pbAddUser.Image")));
            this.pbAddUser.Location = new System.Drawing.Point(494, 16);
            this.pbAddUser.Name = "pbAddUser";
            this.pbAddUser.Size = new System.Drawing.Size(40, 30);
            this.pbAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddUser.TabIndex = 7;
            this.pbAddUser.TabStop = false;
            this.pbAddUser.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ctrInfoPerson1
            // 
            this.ctrInfoPerson1.BackColor = System.Drawing.Color.White;
            this.ctrInfoPerson1.Location = new System.Drawing.Point(3, 89);
            this.ctrInfoPerson1.Name = "ctrInfoPerson1";
            this.ctrInfoPerson1.Size = new System.Drawing.Size(732, 249);
            this.ctrInfoPerson1.TabIndex = 0;
            this.ctrInfoPerson1.Load += new System.EventHandler(this.ctrInfoPerson1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Controls.Add(this.pbAddUser);
            this.groupBox1.Controls.Add(this.lbFind);
            this.groupBox1.Controls.Add(this.pbSearch);
            this.groupBox1.Controls.Add(this.cbFind);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "fillter";
            // 
            // ctrAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrInfoPerson1);
            this.Name = "ctrAddUpdateUser";
            this.Size = new System.Drawing.Size(739, 341);
            this.Load += new System.EventHandler(this.ctrAddUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrInfoPerson ctrInfoPerson1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.PictureBox pbAddUser;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
