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
    public partial class frmAddUpdateUser : Form
    { 
        public enum enMode { Add=0,Udate=1};
        enMode Mode;    
        clsUsers _User ;
        int _UserID;

        public frmAddUpdateUser(int UserID=-1)
        {
            InitializeComponent();
            _UserID = UserID;
            if (_UserID == -1)
            {
                Mode = enMode.Add;
            }
            else
            {
                Mode = enMode.Udate;
            }
        }
       
        private void ctrAddUpdateUser1_Load(object sender, EventArgs e)
        {
            
        }

        private void lbAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (ctrAddUpdateUser1.GetPersonID() != null &&ctrAddUpdateUser1.GetTextFind()!="")
            {
                if (clsUsers.IsExistByPersonID(Convert.ToInt32(ctrAddUpdateUser1.GetPersonID())))
                {
                    MessageBox.Show("This User is Aleardy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btSave.Enabled = true;
                tabPersonInfo.SelectedTab = LoginInfo;
            }
            else
            {
                MessageBox.Show("Can not add user if person is not exist in dataBase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //this.SelectNextControl((Control)sender, true, true, true, true);
                //LoginInfo.Show();
                //tabPersonInfo.SelectNextControl((Control)sender, true, true, true, true);
                return;
            }

        }
        private void _LoadData()
        {
            //btNext.Enabled = false;
            if (Mode == enMode.Add)
            {
            btSave.Enabled = false;
                _User = new clsUsers();
                lbAddUser.Text = "Add New User";
                return;
            }
            _User=clsUsers.Find(_UserID);
            lbAddUser.Text = "Update User";
            ctrLoginInfo1.LoadDataUser(_User);
            //ctrInfoPerson.
            ctrAddUpdateUser1.UserInfo(_User.PersonID);
            Mode = enMode.Udate;
            btSave.Enabled = true;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            ctrLoginInfo1.AddUserInfo(_User);
            _User.PersonID=Convert.ToInt32( ctrAddUpdateUser1.GetPersonID());
            if (_User.Save())
            {
                MessageBox.Show("Saved Data Sucessuflly");
                _UserID = _User.UserID;
                ctrLoginInfo1.SetUserIDAdded(_UserID);
            }
            else
            {
                MessageBox.Show(" Faild Saved Data Sucessuflly");

            }
            
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void ctrAddUpdateUser1_Load_1(object sender, EventArgs e)
        {
            //if(ctrAddUpdateUser1.GetPersonID())
            //if (ctrAddUpdateUser1.IsPersonExist())
            //{
            //    btNext.Enabled = true;
            //}
            //else
            //{
            //    return;
            //}
                
        }
    }
}
