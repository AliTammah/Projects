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

namespace project19
{
    public partial class frmChangePassword : Form
    {
        int _UserID;
        public enum enMode { Add=1,Update=1};
        enMode Mode = enMode.Add;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        clsUsers User;
        private void _LoadData()
        {
            User=clsUsers.Find(_UserID);
            ctrLoginInfromation1.LoadDataUser(User);
            ctrInfoPerson1.PersonInfo(User.PersonID);
            Mode=enMode.Update;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text.ToString() == User.Password.ToString())
            {
                User.Password = txtNewPass.Text;

                if (User.Save())
                {
                    MessageBox.Show("Saved Chanage Successfully");
                }
                else
                {
                    MessageBox.Show("Failed Saved Chanage Successfully");

                }
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _LoadData();    
        }

        private void txtCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPass.Text) || (txtCurrentPass.Text != User.Password))
            {
                errorProvider1.SetError(txtCurrentPass, "Current Password Required");
                e.Cancel = true;
            }
        }

        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                errorProvider1.SetError(txtNewPass, "new Password Required");
                e.Cancel = true;
            }
        }

        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPass.Text) || txtNewPass.Text != txtConfirmPass.Text)
            {
                errorProvider1.SetError(txtConfirmPass, "Inncorrect Password");
                e.Cancel = true;
            }
        }
    }
}
