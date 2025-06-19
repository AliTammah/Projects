using DataBusnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project19
{
    public partial class frmLoginScreen : Form
    {
            clsUsers user;
        string _UserName, _Password;
        public frmLoginScreen()
        {
            InitializeComponent();
           
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            //clsUserSettings userSettings = new clsUserSettings();
         string UserName=txtUserName.Text;
         string Password=txtPassword.Text;
            if (clsUsers.IsExistByUserName(UserName))
            {
                user = clsUsers.FindByUserName(UserName);
                if (user == null)
                {
                    return;
                }
                
                if (user.Password != Password)
                {
                    MessageBox.Show("Incorrect   Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                if (!user.IsActive )
                {
                    MessageBox.Show("USer should be activeted   ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                        string pathfile = @"C:\Users\LENOVO\source\repos\project19\users.txt";
                        string content =  user.UserName.ToString() + " " + user.Password.ToString();
                    if (chxRememberMe.Checked)
                    {

                        using (StreamWriter writer = new StreamWriter(pathfile))
                        {
                            writer.WriteLine(content);
                        }
                    }
                    else
                    {
                        File.Exists(pathfile);
                    
                        File.WriteAllText(pathfile, " ");
                    }
                        clsUserSettings.PersonID = user.PersonID;
                        clsUserSettings.UserName = user.UserName;
                        clsUserSettings.Password = user.Password;
                        clsUserSettings.IsActive=user.IsActive;
                        clsUserSettings.UserID=user.UserID;
                    frmMain frm = new frmMain(user,chxRememberMe.Checked);
                        this.Hide();
                    frm.ShowDialog();
                    this.Close();
                    
                }
                }
                else
            {
                MessageBox.Show("Incorrect UserName Or not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        public  void LoadDataUser(string UserNAme, string Password)
        {
            txtPassword.Text = Password;
            txtUserName.Text = UserNAme;
            chxRememberMe.Checked = true;
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            string userName, Password;
            string pathfile = @"C:\Users\LENOVO\source\repos\project19\users.txt";
            if (File.Exists(pathfile))
            {
                //using (StreamReader reader = new StreamReader(pathfile))
                //{
                //string line;
                string line = File.ReadLines(pathfile).First();

                // تقسيم السطر باستخدام الفراغ كفاصل
                string[] parts = line.Split(' ');

                if (parts.Length >= 2)
                {
                    //isRemember = parts[0];
                    userName = parts[0];
                    Password = parts[1];
                    txtPassword.Text = Password;
                    txtUserName.Text = userName;
                    chxRememberMe.Checked=true;

                }
            }

            }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "UserName Reqquired");
                e.Cancel = true;
                return;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password Is Required");
                e.Cancel = true;
                return;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
