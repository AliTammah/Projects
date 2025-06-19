using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project19
{
    public partial class ctrLoginToAccount : UserControl
    {
        public ctrLoginToAccount()
        {
            InitializeComponent();
        }
        public  string GetUserName()
        {
            return txtUserName.Text.ToString();
        }
        public string GetPassWord()
        {
            return txtPassword.Text.ToString();
        }
        public bool IsRmemberMe()
        {

            return chxRememberMe.Checked;
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName,"UserName Reqquired");
                e.Cancel = true;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password Is Required");
                e.Cancel = true;
            }
        }
        public void LoadDataUser(string UserNAme,string Password)
        {
            txtPassword.Text = Password;
            txtUserName.Text = UserNAme;
            chxRememberMe.Checked = true;
        }
            string username, password;
            string isRemember;
        private void ctrLoginToAccount_Load(object sender, EventArgs e)
        {
            //txtUserName.Focus();
            string pathfile = @"C:\Users\LENOVO\source\repos\project19\users.txt";
            if (File.Exists(pathfile))
            {
                //using (StreamReader reader = new StreamReader(pathfile))
                //{
                //string line;
                string line = File.ReadLines(pathfile).First();

                // تقسيم السطر باستخدام الفراغ كفاصل
                string[] parts = line.Split(' ');

                if (parts.Length >= 3)
                {
                    isRemember = parts[0];
                    username = parts[1];
                    password = parts[2];

                }
                //}
                if (isRemember == "true")
                {
                    txtPassword.Text = password;
                    txtUserName.Text = username;
                    chxRememberMe.Checked = true;
                }
                else
                {
                    txtUserName.Focus();
                    txtUserName.Text = "";
                    txtPassword.Text = " ";
                    chxRememberMe.Checked = false;
                }

            }
        

            

            //else
            //{
            //    
            //}

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
