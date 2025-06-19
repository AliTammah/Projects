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
    public partial class frmVisionTestAppointments : Form
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
        clsTests _Test=new clsTests();
        clsAppointments _Appointments;
       
        public frmVisionTestAppointments(int localID, int TestTypeID)
        {
            InitializeComponent();
            _LocalID = localID;
            _TestTypeID = TestTypeID;
        }
        private void _LoadData()
        {
            AppID = clsLocalDrivingLicenseApplications.Find(_LocalID).AppID;
            ClassID = clsLocalDrivingLicenseApplications.Find(_LocalID).ClassID;
            //_PassedTestCount = passedTestCount;
            _appInfo = clsApplicationInfo.Find(_LocalID);

            applications = clsApplications.Find(AppID);
            licenseClasses= clsLicenseClasses.GetInfoByID(ClassID);
            //_TestTypes = clsTestsTypes.Find(applications.AppTypeID);
            _Appointments = clsAppointments.FindByLocalID(_LocalID);

            ctrChangeProperties1.LoadImageIndTitle(_TestTypeID);
            switch (_TestTypeID)
            {
                case 2:
                    //pbHeader.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\Written Test 512.png");
                    //lbTitle.Text = "Written Test Appointments";
                    //lbHeader.Text = "Written Test";
                    this.Text = "Written Test";

                    break;
                case 3:
                    //pbHeader.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\driving-test 512.png");
                    ////lbTitle.Text = "Written Test Appointments";
                    //lbHeader.Text = "Street Test";
                    this.Text = "Street Test";

                    break;
                default:
                    break;
            }

        }
        //private void _ChangeProperties()
        //{
        //    switch (_TestTypeID) {

        //        case 2:


        //    }
        private void _LoadDataToUserControls()
        {
            ctrDrivingLicenseApplicationInfo1.LoadDataDrivingLocalApp(_LocalID, licenseClasses.ClassName,
   _appInfo.PassedTestAcount);
           ctrApplicationsBasicInfo1.FillAppInfo(_appInfo,applications,licenseClasses);
        }

        private void frmVisionTestApplications_Load(object sender, EventArgs e)
        {
            _LoadData();
            _LoadDataToUserControls();

            //int AppoinID = clsAppointments.FindByLocalID(_LocalID).ID;
            //_TrailCount = dgvAppointments.Rows.Count;
            //if (_TrailCount > 0)
            //{
                _RefrishDataGridveiw();
            //}

        }

        private void ctrDrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public  void _RefrishDataGridveiw()
        {
            if (_Appointments != null)
            {
                DataView dv = clsAppointments.GetAllByID(_LocalID).DefaultView;
                dv.RowFilter = dv.RowFilter = $"Convert([{"TestTypeID"}],'System.String') LIKE '%{_TestTypeID}%'";
                dgvAppointments.DataSource = dv;
                //dgvAppointments.Columns[1].Visible = false;
                dgvAppointments.Columns[2].Visible = false;
                dgvAppointments.Columns[5].Visible = false;
                dgvAppointments.Columns[7].Visible = false;
                _TrailCount = dgvAppointments.Rows.Count;

                return;
            }
            dgvAppointments.DataSource = clsAppointments.GetAllByID(_LocalID).DefaultView;
            dgvAppointments.Columns[1].Visible = false;
            dgvAppointments.Columns[2].Visible = false;
            dgvAppointments.Columns[5].Visible = false;
            _TrailCount = dgvAppointments.Rows.Count ;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails frm=new frmPersonDetails(applications.AppPersonID);
            frm.ShowDialog();   
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (clsAppointments.FindByLocalID(_LocalID) != null)
            {
                int AppoinID = 0;
                int TestID;
                _TrailCount = dgvAppointments.Rows.Count ;

                if (_TrailCount > 0)
                {
                    AppoinID = (int)dgvAppointments.Rows[dgvAppointments.Rows.Count-1 ].Cells[0].Value;
                    _Appointments = clsAppointments.Find(AppoinID);
                    //TestID = clsTests.FindByAppointmentID(AppoinID).ID;
                }
                else
                {


                    AppoinID = clsAppointments.FindByLocalID(_LocalID).ID;
                    //int isExist=clsTests.FindByAppointmentID(AppoinID).AppID;
                    _Appointments = clsAppointments.Find(AppoinID);
                    //TestID = clsTests.FindByAppointmentID(AppoinID).ID;
                }
                if (_Appointments != null&&_Appointments.TesTypeID==_TestTypeID  && _Appointments.IsLocked == false)
                {
                    MessageBox.Show("Sorry, person aleardy have an active  appointments for this test" +
                        " tou can not add new Appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _RefrishDataGridveiw();
                    return;
                }
                _Test = clsTests.FindByAppointmentID(AppoinID);

                if (_Test.result&& _Appointments.TesTypeID == _TestTypeID)
                {
                    MessageBox.Show("Sorry, person aleardy Passed this test before ,you can retake failed tess ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _RefrishDataGridveiw();

                }

                else
                {
                    clsApplications RetakeTestApplication=new clsApplications();
                    RetakeTestApplication.AppPersonID=applications.AppPersonID;
                    RetakeTestApplication.AppDate=applications.AppDate;
                    RetakeTestApplication.AppStatus=applications.AppStatus;
                    RetakeTestApplication.LastStatusDate=DateTime.Now;
                    RetakeTestApplication.PaidFees=clsApplictionsTypeTitle.Find(7).fees;
                    RetakeTestApplication.UserID=clsUserSettings.UserID;
                    RetakeTestApplication.AppTypeID = clsApplictionsTypeTitle.Find(7).AppID;
                    if (RetakeTestApplication.Save())
                    {
                        frmAddUpdateTestAppointments frm = new frmAddUpdateTestAppointments(_LocalID, -1, _TestTypeID,_TrailCount,RetakeTestApplication.ID);
                        frm.ShowDialog();
                        _RefrishDataGridveiw();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, There is Error ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                frmAddUpdateTestAppointments frm = new frmAddUpdateTestAppointments(_LocalID, -1, _TestTypeID, _TrailCount);
                frm.ShowDialog();
                _RefrishDataGridveiw();
            }
            //_RefrishDataGridveiw();
        }
        int AppointID;
        //private void toolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //     AppointID=(int)dgvAppointments.CurrentRow.Cells[0].Value;
        //    frmAddUpdateTestAppointments frm = new frmAddUpdateTestAppointments(_LocalID, AppointID);
        //    frm.ShowDialog();
        //}

        //private void toolStripMenuItem2_Click(object sender, EventArgs e)
        //{
        //    AppointID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

        //    frmTakeTest frm =new frmTakeTest(_LocalID,AppointID);
        //    frm.ShowDialog();
        //}

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            AppointID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            frmAddUpdateTestAppointments frm = new frmAddUpdateTestAppointments(_LocalID, AppointID,_TestTypeID, _TrailCount);
            frm.ShowDialog();
            _RefrishDataGridveiw();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AppointID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

            _Appointments = clsAppointments.Find(AppointID);
            if (_Appointments.IsLocked == false)
            {
                frmTakeTest frm = new frmTakeTest(_LocalID, _TestTypeID, AppointID, _TrailCount);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry, Can not take this test ,you taked ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            _RefrishDataGridveiw();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            //_RefrishDataGridveiw();
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void send()
        {
        }
    }
}
