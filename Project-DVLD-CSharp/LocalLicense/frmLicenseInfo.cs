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
    public partial class frmLicenseInfo : Form
    {
        int _LicenseID=0;
        public frmLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }
        public frmLicenseInfo()
        {
            InitializeComponent();
            //_LicenseID = LicenseID;
        }
        //public frmLicenseInfo(int licenseID)
        //{
        //    InitializeComponent();
        //    //_localID = localID;
        //}
        private void _LoadData()
        {
            ctrLicenseInfo1.FillCTRLicensInfoBylicenseID(_LicenseID);
        }
        public void FillLicenseInfoByLocalID(int localID)
        {
            ctrLicenseInfo1.FillCTRLicensInfo(localID);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            if(_LicenseID!=0)
            _LoadData();

            //FillLicenseInfoByLocalID();
        }
    }
}
