namespace project19
{
    partial class frmManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePeople));
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.editPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.addPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.dalete = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.phonecall = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbRecords = new System.Windows.Forms.Label();
            this.lbNumberRecords = new System.Windows.Forms.Label();
            this.ctrFilterPeople1 = new project19.ctrFilterPeople();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeople.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPeople.Location = new System.Drawing.Point(12, 204);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.Size = new System.Drawing.Size(1056, 198);
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetails,
            this.editPerson,
            this.addPerson,
            this.dalete,
            this.sendEmail,
            this.phonecall});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 136);
            // 
            // showDetails
            // 
            this.showDetails.Image = ((System.Drawing.Image)(resources.GetObject("showDetails.Image")));
            this.showDetails.Name = "showDetails";
            this.showDetails.Size = new System.Drawing.Size(141, 22);
            this.showDetails.Text = "Show Details";
            this.showDetails.Click += new System.EventHandler(this.showDetails_Click);
            // 
            // editPerson
            // 
            this.editPerson.Image = ((System.Drawing.Image)(resources.GetObject("editPerson.Image")));
            this.editPerson.Name = "editPerson";
            this.editPerson.Size = new System.Drawing.Size(141, 22);
            this.editPerson.Text = "Edit Person";
            this.editPerson.Click += new System.EventHandler(this.editPerson_Click);
            // 
            // addPerson
            // 
            this.addPerson.Image = ((System.Drawing.Image)(resources.GetObject("addPerson.Image")));
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(141, 22);
            this.addPerson.Text = "Add Person";
            // 
            // dalete
            // 
            this.dalete.Image = global::project19.Properties.Resources.Delete_32;
            this.dalete.Name = "dalete";
            this.dalete.Size = new System.Drawing.Size(141, 22);
            this.dalete.Text = "Delete";
            this.dalete.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sendEmail
            // 
            this.sendEmail.Image = ((System.Drawing.Image)(resources.GetObject("sendEmail.Image")));
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(141, 22);
            this.sendEmail.Text = "Send Email";
            // 
            // phonecall
            // 
            this.phonecall.Image = ((System.Drawing.Image)(resources.GetObject("phonecall.Image")));
            this.phonecall.Name = "phonecall";
            this.phonecall.Size = new System.Drawing.Size(141, 22);
            this.phonecall.Text = "Phone Call";
            // 
            // pbPeople
            // 
            this.pbPeople.Image = ((System.Drawing.Image)(resources.GetObject("pbPeople.Image")));
            this.pbPeople.Location = new System.Drawing.Point(446, 2);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(140, 141);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 1;
            this.pbPeople.TabStop = false;
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("Tahoma", 17F);
            this.lbManagePeople.ForeColor = System.Drawing.Color.Red;
            this.lbManagePeople.Location = new System.Drawing.Point(441, 162);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(166, 28);
            this.lbManagePeople.TabIndex = 2;
            this.lbManagePeople.Text = "Manage People";
            // 
            // btAddPerson
            // 
            this.btAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btAddPerson.Image")));
            this.btAddPerson.Location = new System.Drawing.Point(1004, 147);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(64, 51);
            this.btAddPerson.TabIndex = 4;
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(949, 409);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbRecords.Location = new System.Drawing.Point(32, 422);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(73, 17);
            this.lbRecords.TabIndex = 6;
            this.lbRecords.Text = "#Records:";
            this.lbRecords.Click += new System.EventHandler(this.lbRecords_Click);
            // 
            // lbNumberRecords
            // 
            this.lbNumberRecords.AutoSize = true;
            this.lbNumberRecords.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbNumberRecords.Location = new System.Drawing.Point(111, 422);
            this.lbNumberRecords.Name = "lbNumberRecords";
            this.lbNumberRecords.Size = new System.Drawing.Size(29, 17);
            this.lbNumberRecords.TabIndex = 7;
            this.lbNumberRecords.Text = "???";
            this.lbNumberRecords.Click += new System.EventHandler(this.lbNumberRecords_Click);
            // 
            // ctrFilterPeople1
            // 
            this.ctrFilterPeople1.Location = new System.Drawing.Point(12, 132);
            this.ctrFilterPeople1.Name = "ctrFilterPeople1";
            this.ctrFilterPeople1.Size = new System.Drawing.Size(399, 66);
            this.ctrFilterPeople1.TabIndex = 8;
            this.ctrFilterPeople1.OnFilterPeople += new System.Action<string>(this.ctrFilterPeople1_OnFilterPeople);
            this.ctrFilterPeople1.Load += new System.EventHandler(this.ctrFilterPeople1_Load);
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 457);
            this.Controls.Add(this.ctrFilterPeople1);
            this.Controls.Add(this.lbNumberRecords);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.lbManagePeople);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.dgvPeople);
            this.Name = "frmManagePeople";
            this.Text = "frmManagePeople";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label lbNumberRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetails;
        private System.Windows.Forms.ToolStripMenuItem editPerson;
        private System.Windows.Forms.ToolStripMenuItem addPerson;
        private System.Windows.Forms.ToolStripMenuItem dalete;
        private ctrFilterPeople ctrFilterPeople1;
        private System.Windows.Forms.ToolStripMenuItem sendEmail;
        private System.Windows.Forms.ToolStripMenuItem phonecall;
    }
}