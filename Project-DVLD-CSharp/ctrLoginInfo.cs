using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusnissLayer;
namespace project19
{
    public partial class ctrLoginInfo : UserControl
    {
        public ctrLoginInfo()
        {
            InitializeComponent();
        }
        clsUsers User=new clsUsers();
        public void SetUserIDAdded(int userID)
        {
            lbUserIDAdded.Text = userID.ToString();
        }
        public void LoadDataUser(clsUsers user)
        {
            lbUserIDAdded.Text=user.UserID.ToString();
            txtConfirmPassword.Text=user.Password;
            txtPassword.Text=user.Password;
            txtUserName.Text=user.UserName;
            chxIsActive.Checked=Convert.ToBoolean( user.IsActive);
        }
        public void AddUserInfo(clsUsers UserToUpdate)
        {
            UserToUpdate.UserName = txtUserName.Text;

            UserToUpdate.Password = txtPassword.Text;
            
            //User.PersonID=ctrAddUpdateUser1.PersonID;
            if (chxIsActive.Checked)
            {
                UserToUpdate.IsActive = true;
            }
            else
            {
                UserToUpdate.IsActive = false;
            }
          

        }

        private void ctrLoginInfo_Load(object sender, EventArgs e)
        {
            

        

        }

        private void txtUserName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "UserName Required");
                e.Cancel = true;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password Required");
                e.Cancel = true;
            }

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text) || txtConfirmPassword.Text != txtPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Password Incorrect");
                e.Cancel = true;    
            }
        }
    }
}
