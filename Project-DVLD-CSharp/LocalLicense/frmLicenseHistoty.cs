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
using DataBusnissLayer;

namespace project19
{
    public partial class frmLicenseHistoty : Form
    {
        int _DriverID;
        clspeople _person;
        public frmLicenseHistoty(int DriverID)
        {
            InitializeComponent();
            _DriverID = DriverID;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadLicenseLocal()
        {
            //int personID=
            //_person=clsLicense.GetInfoPerson(_LocalID);
            ctrLicenseHistory1.referishLocalLicense(_DriverID);
            ctrAddUpdateUser1.FillPersonInfo(clsDrivers.Find(_DriverID).PersonID);
        }
        private void ctrLicenseHistory1_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrAddUpdateUser1_Load(object sender, EventArgs e)
        {

        }

        private void frmLicenseHistoty_Load(object sender, EventArgs e)
        {
            _LoadLicenseLocal();
            
        }
    }
}
