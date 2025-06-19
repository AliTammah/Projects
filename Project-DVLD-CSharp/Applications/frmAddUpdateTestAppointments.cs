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
    public partial class frmAddUpdateTestAppointments : Form
    {
        public enum enMode { Add=0,Update=1};
        enMode Mode = enMode.Add;
        int _LocalID;
        int _TrialCount ;
        int _AppoinID;
        int AppID;
        int ClassID;
        int _TestTypeID;
        int ?_RetakeTestAppID;
        clsUsers _CueentUser;
        clsApplications _Application;
        clsApplicationInfo _ApplicationInfo;
        clsTestsTypes _TestsTypes;
        clsLicenseClasses _LicenseClasses;
        clsAppointments _Appointment;
        clsTests _Test;
        public frmAddUpdateTestAppointments(int localID, int appoinID, int testTypeID,int TrailCount,int? RetakeTestAppID=null)
        {
            InitializeComponent();
            _LocalID = localID;
            _AppoinID = appoinID;
            if (_AppoinID == -1)
            {
                Mode = enMode.Add;
            }
            else
            {
                Mode = enMode.Update;
            }

            _TestTypeID = testTypeID;
           
            _TrialCount= TrailCount;
            _RetakeTestAppID= RetakeTestAppID;
        }
        private void _LoadData()
        {
             AppID=clsLocalDrivingLicenseApplications.Find(_LocalID).AppID;
             ClassID=clsLocalDrivingLicenseApplications.Find(_LocalID).ClassID;
            _Application=clsApplications.Find(AppID);
            _ApplicationInfo = clsApplicationInfo.Find(_LocalID);
            _LicenseClasses=clsLicenseClasses.GetInfoByID(ClassID);
            _Test = clsTests.FindByAppointmentID(_AppoinID);
            _TestsTypes = clsTestsTypes.Find(_TestTypeID);
            ctrChangeProperties1.LoadImageIndTitle(_TestTypeID);
            if (_TrialCount==0)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
                retakeTestInfo1.LoadDataToUserRetakeInfo(clsApplictionsTypeTitle.Find(7).fees, _TestsTypes.TestFees);
            }
            if (Mode == enMode.Add)
            {
                _Appointment = new clsAppointments();
              
                return;
            }
            _Appointment = clsAppointments.Find(_AppoinID);
            if (_Appointment == null)
            {
                return;
            }
            else
            {
                if (ctrAddUpdateTestAppointments1.LoadDataToUserControl(_Appointment))
                {

                    btSave.Enabled = false;
                }
                else
                {
                    btSave.Enabled = true;
                }
                groupBox1.Enabled = false;

            }

        }
        private void _LoadControlData()
        {
            ctrAddUpdateTestAppointments1.FillDataAppointments(_Application,_ApplicationInfo, _LicenseClasses,_TrialCount);
        }
        private void _FillAppointments()
        {
            _Appointment.TesTypeID=_TestTypeID;
            _Appointment.UserID=clsUserSettings.UserID;
            _Appointment.LocalID=_LocalID;
            _Appointment.RTAppID=_RetakeTestAppID;
            ctrAddUpdateTestAppointments1.SaveDataToObject(_Appointment);

        }
        public void GetRetakeTestApplicationID(int? RetaketestAppID=null)
        {
            _Appointment.RTAppID = RetaketestAppID;
        }
        private void frmAddUpdateTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadData();
            _LoadControlData();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int GetAppointmentID()
        {

            return _Appointment.ID;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _FillAppointments();
            if (_Appointment.Save())
            {
                MessageBox.Show("Saved Data Successfully ");
            }
            else
            {
                MessageBox.Show("Failed Saved Data Successfully ","error",MessageBoxButtons.OK,MessageBoxIcon.Error );

            }
        }

        private void ctrAddUpdateTestAppointments1_Load(object sender, EventArgs e)
        {

        }
    }
}
