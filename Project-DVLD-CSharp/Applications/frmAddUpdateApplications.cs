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
    public partial class frmAddUpdateApplications : Form
    {
         public  enum enMode { Add=0,Update=1 }
        enMode _Mode=enMode.Add;
        int _AppID;
        bool _IsRetake=false;
        int _TypeAppID;
        clsUsers _User;
        clsApplications _Application=new clsApplications();
       clsApplictionsTypeTitle _ApplictionsTypeTitle=new clsApplictionsTypeTitle();
       clsLocalDrivingLicenseApplications _LocalLicenseApplications=new clsLocalDrivingLicenseApplications() ;
        public frmAddUpdateApplications(int AppID)  
        {
            InitializeComponent();
            if (AppID == -1)
            {
                _Mode = enMode.Add;
            }
            else
            {
                _Mode = enMode.Update;
            }
            //_User = CurrentUser;
            //_IsRetake = isretake;
            //_TypeAppID = TypeAppID;
        }
        private void _LoadData()
        {
            if (_Mode == enMode.Add) {
            
            //label1 = new Label();
            _Application = new clsApplications();
                return;
            }
            _Application=clsApplications.Find(_AppID);

            
        }
        private void _LoadDataToObject()
        {
            _Application.LastStatusDate = DateTime.Now.Date;
            _Application.AppPersonID=Convert.ToInt32( ctrAddUpdateUser1.GetPersonID());
            _Application.AppStatus = 1;
            _Application.AppTypeID = clsApplictionsTypeTitle.Find(Convert.ToInt16( clsApplictionsTypeTitle.GetIdByName("NewLocalDrivingLicenseService"))).AppID;
            _Application.UserID=clsUserSettings.UserID;
            ctrApplicationInfo1.LoadDataToObject(_Application);


        }
        private void _FillCombobox()
        {
           
            
        }

        private void frmAddUpdateApplications_Load(object sender, EventArgs e)
        {
            ctrApplicationInfo1. _FillCombobox();
           
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (ctrAddUpdateUser1.GetPersonID() != null && ctrAddUpdateUser1.GetTextFind() != "")
            {
                //if (clsUsers.IsExistByPersonID(Convert.ToInt32(ctrAddUpdateUser1.GetPersonID())))
                //{
                //    MessageBox.Show("This User is Aleardy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                btSave.Enabled = true;
                tabControl1.SelectedTab = tabPage2;
                ctrApplicationInfo1.GetAppFeesAndDate();


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

        private void btSave_Click(object sender, EventArgs e)
        {
            _LoadDataToObject();
            int ClassID = ctrApplicationInfo1.GetClassID();
            _LocalLicenseApplications.ClassID = ClassID;
            if (ctrApplicationInfo1.GetAllLocalDriving(ctrAddUpdateUser1.GetPersonNational()))
            {
                if (_Application.Save())
                {
                    _LocalLicenseApplications.AppID = _Application.ID;
                    if (_LocalLicenseApplications.Save())
                    {
                        MessageBox.Show("Saved Data Successfully ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrApplicationInfo1.SetAppID(_Application.ID);
                        lbAppUserID.Text = clsUserSettings.UserName;
                    }
                    else
                    {
                        MessageBox.Show("Failed Saved Data Successfully ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Failed Saved Data Successfully ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Choose another license class ,the selected person is aleardy ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
