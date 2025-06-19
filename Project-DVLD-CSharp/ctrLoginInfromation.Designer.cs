namespace project19
{
    partial class ctrLoginInfromation
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
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbIDUser = new System.Windows.Forms.Label();
            this.lbUserN = new System.Windows.Forms.Label();
            this.lbisAct = new System.Windows.Forms.Label();
            this.lbLoginInfro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbUserID.Location = new System.Drawing.Point(156, 31);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(64, 19);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "UserID:";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbIsActive.Location = new System.Drawing.Point(504, 31);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(76, 19);
            this.lbIsActive.TabIndex = 1;
            this.lbIsActive.Text = "Is Active:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbUserName.Location = new System.Drawing.Point(310, 31);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(88, 19);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "UserName:";
            // 
            // lbIDUser
            // 
            this.lbIDUser.AutoSize = true;
            this.lbIDUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbIDUser.Location = new System.Drawing.Point(227, 31);
            this.lbIDUser.Name = "lbIDUser";
            this.lbIDUser.Size = new System.Drawing.Size(33, 19);
            this.lbIDUser.TabIndex = 3;
            this.lbIDUser.Text = "???";
            // 
            // lbUserN
            // 
            this.lbUserN.AutoSize = true;
            this.lbUserN.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbUserN.Location = new System.Drawing.Point(404, 31);
            this.lbUserN.Name = "lbUserN";
            this.lbUserN.Size = new System.Drawing.Size(33, 19);
            this.lbUserN.TabIndex = 4;
            this.lbUserN.Text = "???";
            // 
            // lbisAct
            // 
            this.lbisAct.AutoSize = true;
            this.lbisAct.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbisAct.Location = new System.Drawing.Point(586, 31);
            this.lbisAct.Name = "lbisAct";
            this.lbisAct.Size = new System.Drawing.Size(33, 19);
            this.lbisAct.TabIndex = 5;
            this.lbisAct.Text = "???";
            // 
            // lbLoginInfro
            // 
            this.lbLoginInfro.AutoSize = true;
            this.lbLoginInfro.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbLoginInfro.Location = new System.Drawing.Point(3, 0);
            this.lbLoginInfro.Name = "lbLoginInfro";
            this.lbLoginInfro.Size = new System.Drawing.Size(137, 19);
            this.lbLoginInfro.TabIndex = 6;
            this.lbLoginInfro.Text = "Login Infromation";
            // 
            // ctrLoginInfromation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLoginInfro);
            this.Controls.Add(this.lbisAct);
            this.Controls.Add(this.lbUserN);
            this.Controls.Add(this.lbIDUser);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbIsActive);
            this.Controls.Add(this.lbUserID);
            this.Name = "ctrLoginInfromation";
            this.Size = new System.Drawing.Size(691, 75);
            this.Load += new System.EventHandler(this.ctrLoginInfromation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbIDUser;
        private System.Windows.Forms.Label lbUserN;
        private System.Windows.Forms.Label lbisAct;
        private System.Windows.Forms.Label lbLoginInfro;
    }
}
