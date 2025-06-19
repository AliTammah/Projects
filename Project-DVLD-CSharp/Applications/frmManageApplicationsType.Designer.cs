namespace project19
{
    partial class frmManageApplicationsType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplicationsType));
            this.lbManageAppType = new System.Windows.Forms.Label();
            this.dgvApplicationsType = new System.Windows.Forms.DataGridView();
            this.lbNumberRecords = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbManageAppType
            // 
            this.lbManageAppType.AutoSize = true;
            this.lbManageAppType.Font = new System.Drawing.Font("Tahoma", 17F);
            this.lbManageAppType.ForeColor = System.Drawing.Color.Red;
            this.lbManageAppType.Location = new System.Drawing.Point(154, 168);
            this.lbManageAppType.Name = "lbManageAppType";
            this.lbManageAppType.Size = new System.Drawing.Size(276, 28);
            this.lbManageAppType.TabIndex = 4;
            this.lbManageAppType.Text = "Manage Applications Type";
            // 
            // dgvApplicationsType
            // 
            this.dgvApplicationsType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvApplicationsType.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplicationsType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationsType.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApplicationsType.Location = new System.Drawing.Point(52, 210);
            this.dgvApplicationsType.Name = "dgvApplicationsType";
            this.dgvApplicationsType.Size = new System.Drawing.Size(508, 197);
            this.dgvApplicationsType.TabIndex = 5;
            // 
            // lbNumberRecords
            // 
            this.lbNumberRecords.AutoSize = true;
            this.lbNumberRecords.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbNumberRecords.Location = new System.Drawing.Point(89, 424);
            this.lbNumberRecords.Name = "lbNumberRecords";
            this.lbNumberRecords.Size = new System.Drawing.Size(29, 17);
            this.lbNumberRecords.TabIndex = 9;
            this.lbNumberRecords.Text = "???";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbRecords.Location = new System.Drawing.Point(10, 424);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(73, 17);
            this.lbRecords.TabIndex = 8;
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
            this.btClose.Location = new System.Drawing.Point(441, 413);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.Image = ((System.Drawing.Image)(resources.GetObject("pbPeople.Image")));
            this.pbPeople.Location = new System.Drawing.Point(224, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(156, 141);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 3;
            this.pbPeople.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 26);
            this.contextMenuStrip1.Text = "Edit Application";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Edit Application";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frmManageApplicationsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.lbNumberRecords);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dgvApplicationsType);
            this.Controls.Add(this.lbManageAppType);
            this.Controls.Add(this.pbPeople);
            this.Name = "frmManageApplicationsType";
            this.Text = "frmManageApplicationsType";
            this.Load += new System.EventHandler(this.frmManageApplicationsType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManageAppType;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.DataGridView dgvApplicationsType;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbNumberRecords;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}