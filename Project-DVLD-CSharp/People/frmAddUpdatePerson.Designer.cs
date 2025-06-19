namespace project19
{
    partial class frmAddUpdatePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            this.lbAddPerson = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.ccrAddUpdatePerson1 = new project19.ccrAddUpdatePerson();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNA = new System.Windows.Forms.Label();
            this.lbPersonIDAdded = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddPerson
            // 
            this.lbAddPerson.AutoSize = true;
            this.lbAddPerson.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lbAddPerson.ForeColor = System.Drawing.Color.Red;
            this.lbAddPerson.Location = new System.Drawing.Point(277, -3);
            this.lbAddPerson.Name = "lbAddPerson";
            this.lbAddPerson.Size = new System.Drawing.Size(210, 33);
            this.lbAddPerson.TabIndex = 1;
            this.lbAddPerson.Text = "Add New Person";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.FlatAppearance.BorderSize = 2;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(426, 405);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 36);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "   Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 2;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(283, 405);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(119, 36);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "     Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ccrAddUpdatePerson1
            // 
            this.ccrAddUpdatePerson1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ccrAddUpdatePerson1.CountryID = 0;
            this.ccrAddUpdatePerson1.Location = new System.Drawing.Point(12, 70);
            this.ccrAddUpdatePerson1.Name = "ccrAddUpdatePerson1";
            this.ccrAddUpdatePerson1.Size = new System.Drawing.Size(769, 329);
            this.ccrAddUpdatePerson1.TabIndex = 4;
            this.ccrAddUpdatePerson1.Load += new System.EventHandler(this.ccrAddUpdatePerson1_Load_1);
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbPersonID.Location = new System.Drawing.Point(12, 48);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(80, 19);
            this.lbPersonID.TabIndex = 5;
            this.lbPersonID.Text = "PersonID:";
            this.lbPersonID.Click += new System.EventHandler(this.lbPersonID_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbNA
            // 
            this.lbNA.AutoSize = true;
            this.lbNA.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbNA.Location = new System.Drawing.Point(179, 48);
            this.lbNA.Name = "lbNA";
            this.lbNA.Size = new System.Drawing.Size(37, 19);
            this.lbNA.TabIndex = 7;
            this.lbNA.Text = "N/A";
            // 
            // lbPersonIDAdded
            // 
            this.lbPersonIDAdded.AutoSize = true;
            this.lbPersonIDAdded.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbPersonIDAdded.Location = new System.Drawing.Point(98, 48);
            this.lbPersonIDAdded.Name = "lbPersonIDAdded";
            this.lbPersonIDAdded.Size = new System.Drawing.Size(0, 19);
            this.lbPersonIDAdded.TabIndex = 8;
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 457);
            this.Controls.Add(this.lbPersonIDAdded);
            this.Controls.Add(this.lbNA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.ccrAddUpdatePerson1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbAddPerson);
            this.Name = "frmAddUpdatePerson";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbAddPerson;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private ccrAddUpdatePerson ccrAddUpdatePerson1;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNA;
        private System.Windows.Forms.Label lbPersonIDAdded;
    }
}

