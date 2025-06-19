namespace Login_Project
{
    partial class Form1
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
            this.btCreate = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.SystemColors.Window;
            this.btCreate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.Location = new System.Drawing.Point(288, 156);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(172, 54);
            this.btCreate.TabIndex = 0;
            this.btCreate.Text = "Create Acount";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.Window;
            this.btLogin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Image = global::Login_Project.Properties.Resources.Login;
            this.btLogin.Location = new System.Drawing.Point(312, 216);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(172, 63);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(617, 166);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(81, 80);
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.Text = "guna2CircleButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btLogin;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}

