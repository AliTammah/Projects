namespace project19
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.editPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.addPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.dalete = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.phonecall = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.ctrFilterUsers1 = new project19.ctrFilterUsers();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("Tahoma", 17F);
            this.lbManagePeople.ForeColor = System.Drawing.Color.Red;
            this.lbManagePeople.Location = new System.Drawing.Point(312, 160);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(154, 28);
            this.lbManagePeople.TabIndex = 11;
            this.lbManagePeople.Text = "Manage Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsers.Location = new System.Drawing.Point(12, 273);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(779, 218);
            this.dgvUsers.TabIndex = 9;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetails,
            this.editPerson,
            this.addPerson,
            this.dalete,
            this.sendEmail,
            this.phonecall,
            this.changePassword});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 158);
            // 
            // showDetails
            // 
            this.showDetails.Image = ((System.Drawing.Image)(resources.GetObject("showDetails.Image")));
            this.showDetails.Name = "showDetails";
            this.showDetails.Size = new System.Drawing.Size(168, 22);
            this.showDetails.Text = "Show Details";
            this.showDetails.Click += new System.EventHandler(this.showDetails_Click);
            // 
            // editPerson
            // 
            this.editPerson.Image = ((System.Drawing.Image)(resources.GetObject("editPerson.Image")));
            this.editPerson.Name = "editPerson";
            this.editPerson.Size = new System.Drawing.Size(168, 22);
            this.editPerson.Text = "Edit User";
            this.editPerson.Click += new System.EventHandler(this.editPerson_Click);
            // 
            // addPerson
            // 
            this.addPerson.Image = ((System.Drawing.Image)(resources.GetObject("addPerson.Image")));
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(168, 22);
            this.addPerson.Text = "Add New User";
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // dalete
            // 
            this.dalete.Image = global::project19.Properties.Resources.Delete_32;
            this.dalete.Name = "dalete";
            this.dalete.Size = new System.Drawing.Size(168, 22);
            this.dalete.Text = "Delete";
            this.dalete.Click += new System.EventHandler(this.dalete_Click);
            // 
            // sendEmail
            // 
            this.sendEmail.Image = ((System.Drawing.Image)(resources.GetObject("sendEmail.Image")));
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(168, 22);
            this.sendEmail.Text = "Send Email";
            // 
            // phonecall
            // 
            this.phonecall.Image = ((System.Drawing.Image)(resources.GetObject("phonecall.Image")));
            this.phonecall.Name = "phonecall";
            this.phonecall.Size = new System.Drawing.Size(168, 22);
            this.phonecall.Text = "Phone Call";
            // 
            // changePassword
            // 
            this.changePassword.Image = ((System.Drawing.Image)(resources.GetObject("changePassword.Image")));
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(168, 22);
            this.changePassword.Text = "Change Password";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // btAddPerson
            // 
            this.btAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btAddPerson.Image")));
            this.btAddPerson.Location = new System.Drawing.Point(727, 216);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(64, 51);
            this.btAddPerson.TabIndex = 14;
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.Image = ((System.Drawing.Image)(resources.GetObject("pbPeople.Image")));
            this.pbPeople.Location = new System.Drawing.Point(317, 13);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(149, 144);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 10;
            this.pbPeople.TabStop = false;
            // 
            // ctrFilterUsers1
            // 
            this.ctrFilterUsers1.Location = new System.Drawing.Point(12, 205);
            this.ctrFilterUsers1.Name = "ctrFilterUsers1";
            this.ctrFilterUsers1.Size = new System.Drawing.Size(415, 62);
            this.ctrFilterUsers1.TabIndex = 15;
            this.ctrFilterUsers1.OnFilterUsers += new System.Action<string>(this.ctrFilterUsers1_OnFilterUsers_1);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(690, 523);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 16;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 561);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.ctrFilterUsers1);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.lbManagePeople);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmManageUsers";
            this.Text = "frmManageUsers";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetails;
        private System.Windows.Forms.ToolStripMenuItem editPerson;
        private System.Windows.Forms.ToolStripMenuItem addPerson;
        private System.Windows.Forms.ToolStripMenuItem dalete;
        private System.Windows.Forms.ToolStripMenuItem sendEmail;
        private System.Windows.Forms.ToolStripMenuItem phonecall;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
        private System.Windows.Forms.Button btAddPerson;
        private ctrFilterUsers ctrFilterUsers1;
        private System.Windows.Forms.Button btClose;
    }
}