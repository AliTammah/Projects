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
    public partial class ctrInternationalLicense : UserControl
    {
        public ctrInternationalLicense()
        {
            InitializeComponent();
        }
        clsLicense _license;
        int LicenseID;
        int _LocalID;
        public event Action<int> OnLicenseID;

        private void OnLicnesIDRenew(int LicenseID)
        {

            Action<int> filter = OnLicenseID;
            if (filter != null)
            {
                filter(LicenseID);
            }
        }
        private void ctrLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void gbDLInfo_Enter(object sender, EventArgs e)
        {

        }

        private void ctrInternationalLicense_Load(object sender, EventArgs e)
        {

        }
        public void FillUserControlLicenseInfo(int LocalID)
        {
            ctrLicenseInfo2.FillCTRLicensInfo(LocalID);
        }
        public bool DisablleFilter(int licenseID)
        {
            groupBox2.Enabled= false;
            txtFind.Text=licenseID.ToString();
            return true;
        }
        public void FillUserControlLicenseInfoByLicenseID(int LicenseID)
        {
            ctrLicenseInfo2.FillCTRLicensInfoBylicenseID(LicenseID);
        }
       public void SaveDataInterNational(clsInternational international)
        {
            international.ApplicationID=_license.ApplicationID;
            international.IssuedUsingLocalLicenseID=_license.LicenseID;
            international.DriverID=_license.DriverID;
            international.IsActive=_license.IsActive;
            
        }
        private void _LoadData()
        {
            LicenseID = Convert.ToInt16(txtFind.Text);
        }
        public  int GetLicenseID()
        {
            return Convert.ToInt16( txtFind.Text);
        }
        //public static string GetApplicationDate()
        //{
        //    return txtFind.Text.ToString();
        //}
        public bool IsExist()
        {
            if (clsInternational.ISExistByLocalID(_license.LicenseID)){
                return true;
            }
            return false;
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    _license = clsLicense.Find(Convert.ToInt32(txtFind.Text));
        //    _LocalID = _license.GetLocalID();
        //    if (_license == null  )
        //    {
        //        MessageBox.Show("This License Not found  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    if (clsLicenseClasses.GetInfoByID(_license.LicenseClass).ClassID != 3)
        //    {
        //        MessageBox.Show("This license class is not type class3   ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    if (_license.IsActive)
        //    {
        //        //_LocalID = _license.GetLocalID();
        //        ctrLicenseInfo1.FillCTRLicensInfo(_LocalID);
        //    }
        //    else
        //    {
        //        MessageBox.Show("This license  local  license is not Active  ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //    }
        //    //ctrLicenseApplicationInfo1
        //}

        private void ctrInternationalInfo1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OnLicnesIDRenew(Convert.ToInt32( txtFind.Text));
        }

        //private void txtFind_TextChanged(object sender, EventArgs e)
        //{
        //}
    }
}
