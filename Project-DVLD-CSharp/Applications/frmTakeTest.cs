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
    public partial class frmTakeTest : Form
    {
        int _LocalID;
        int AppID;
        int ClassID;
        int _TrailCount;
        int _AppointmentTestID;
        int _TestTypeID;
        clsUsers _CurrentUser;

        public frmTakeTest(int localID ,int testTypeID, int appointmentTestID,int TrailCount)
        {
            InitializeComponent();
            _LocalID = localID;
            _AppointmentTestID = appointmentTestID;
            _TrailCount = TrailCount;
            _TestTypeID = testTypeID;
        }
        clsApplications _Application;
        clsApplicationInfo _ApplicationInfo;
        clsTestsTypes _TestsTypes;
        clsLicenseClasses _LicenseClasses;
        clsAppointments _Appointment;
        clsTests _Test=new clsTests()  ;
        
        private void _LoadData()
        {
            AppID = clsLocalDrivingLicenseApplications.Find(_LocalID).AppID;
            ClassID = clsLocalDrivingLicenseApplications.Find(_LocalID).ClassID;
            _Application = clsApplications.Find(AppID);
            _ApplicationInfo = clsApplicationInfo.Find(_LocalID);
            _LicenseClasses = clsLicenseClasses.GetInfoByID(ClassID);
            _Appointment = clsAppointments.Find(_AppointmentTestID);
            switch (_TestTypeID)
            {
                case 2:
                    pbHeader.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\Written Test 512.png");
                    //lbTitle.Text = "Written Test Appointments";
                    lbHeader.Text = "Written Test";
                    this.Text = "Written Test";

                    break;
                case 3:
                    pbHeader.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\driving-test 512.png");
                    //lbTitle.Text = "Written Test Appointments";
                    lbHeader.Text = "Street Test";
                    this.Text = "Street Test";

                    break;
                default:
                    break;
            }
        }
        private void _LoadControlData()
        {
            ctrAddUpdateTestAppointments1.FillDataAppointments(_Application, _ApplicationInfo, _LicenseClasses,_TrailCount);
        }
        private void _FillAppointments()
        {
            _Appointment.TesTypeID = clsTestsTypes.Find(1).TestID;
            _Appointment.UserID = clsUserSettings.UserID;
            _Appointment.LocalID = _LocalID;
            ctrAddUpdateTestAppointments1.SaveDataToObject(_Appointment);

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _Test.notes=txtNotes.Text;
            _Test.AppID = _AppointmentTestID;
            if (rbFail.Checked)
            {
                _Test.result = false;
            }
            else
            {
                _Test.result=true;
            }
            _Test.UserID= clsUserSettings.UserID;
            if (_Test.Save())
            {
                if (_Appointment == null)
                {
                    _Appointment =clsAppointments.Find(_AppointmentTestID); // أنشئ نسخة جديدة
                }
                _Appointment.IsLocked=true;
                _Appointment.Save();
                MessageBox.Show("Saved Data successfully ");
            }
            else
            {
                MessageBox.Show("Failed Saved Data successfully ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _LoadData();    
            _LoadControlData();
        }
    }
}
