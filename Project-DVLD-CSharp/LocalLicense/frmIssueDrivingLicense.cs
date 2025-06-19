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
using System.Xml.Serialization;

namespace project19
{
    public partial class frmIssueDrivingLicense : Form
    {
        int _LocalID;
        int AppID, ClassID;
        int _TrailCount;
        int _AppointmentID;
        int _TestTypeID;
        clsApplications applications;
        clsLicenseClasses licenseClasses;
        int _PassedTestCount;
        clsApplicationInfo _appInfo;
        clsTestsTypes _TestTypes;
        clsTests _Test = new clsTests();
        clsAppointments _Appointments;
        clsUsers _CurrentUser;
        clsLicense _license= new clsLicense();
        clsDrivers _Driver= new clsDrivers();
        public frmIssueDrivingLicense(int localID)
        {
            //InitializeComponent();
            InitializeComponent();
            _LocalID = localID;
            //_CurrentUser = currentUser;
            //_TestTypeID = TestTypeID;
        
        }
        private void _LoadData()
        {
            AppID = clsLocalDrivingLicenseApplications.Find(_LocalID).AppID;
            ClassID = clsLocalDrivingLicenseApplications.Find(_LocalID).ClassID;
            //_PassedTestCount = passedTestCount;
            _appInfo = clsApplicationInfo.Find(_LocalID);

            applications = clsApplications.Find(AppID);
            licenseClasses = clsLicenseClasses.GetInfoByID(ClassID);
        }

        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
            _LoadDataToUserControls();  
        }
        private void _SaveDataToObject()
        {
            _Driver.PersonID=applications.AppPersonID;
            _Driver.CreatedDate=DateTime.Now;
            _Driver.CreatedByUserID=clsUserSettings.UserID;
            if (_Driver.Save())
            {
                _license.ApplicationID=AppID;
                _license.DriverID = _Driver.DriverID;
                _license.LicenseClass=ClassID;
                _license.IssueDate=DateTime.Now;
                _license.ExpirationDate = DateTime.Today.AddYears(licenseClasses.ValidityAge);
                _license.PaidFees =Convert.ToInt16( licenseClasses.ClassFees);
                _license.Notes = textBox1.Text;
                _license.IsActive= true;
                _license.IssueReason = 1;
                _license.UserID = clsUserSettings.UserID;
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _SaveDataToObject();
            if (_license.Save())
            {
                MessageBox.Show("Saved Data Successuffly");
            }
            else
            {
                MessageBox.Show("Failed Saved Data Successuffly","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void _LoadDataToUserControls()
        {
            ctrDrivingLicenseApplicationInfo1.LoadDataDrivingLocalApp(_LocalID, licenseClasses.ClassName,
   _appInfo.PassedTestAcount);
            ctrApplicationsBasicInfo1.FillAppInfo(_appInfo, applications, licenseClasses);
        }
    }
}
