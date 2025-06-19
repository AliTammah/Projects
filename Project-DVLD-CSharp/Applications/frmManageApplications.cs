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
using static System.Net.Mime.MediaTypeNames;
namespace project19
{
    public partial class frmManageApplications : Form
    {
        clsUsers _User;
        int _PassedCount;
        int _AppID;
        public frmManageApplications(clsUsers CurrentUser)
        {
            InitializeComponent();
            _User = CurrentUser;
        }
        private void _ReferishGridVeiw()
        {
            dgvApplications.DataSource = clsApplications.GetAll();
            lbNumberRecords.Text=dgvApplications.RowCount.ToString();
        }


        private void frmManageApplications_Load(object sender, EventArgs e)
        {
            _ReferishGridVeiw();
            _FillFilterBox();
          
        }
        //public Dictionary<string,string>
        private void _FillFilterBox()
        {
          var  filterNames = new Dictionary<string, string>
        {
            {"None","None" },
            {"LocalDrivingLicenseApplicationID","L.D.L.AppID" },
            {"NationalNo"," National No" },
            {"FullName","Full Name" },
            {"Status","Status" }
        };

            ctrFilterLocalDrivingApplications1.FilterColumns = filterNames;
            //ctrFilterPeople1.SourceData=

                
            
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateApplications frm=new frmAddUpdateApplications(-1);
            frm.ShowDialog();
            _ReferishGridVeiw();
        }

        private void ctrFilterLocalDrivingApplications1_OnFilterLocalApplications(string obj)
        {
            //string Text=obj.ToString();
            string columName = ctrFilterLocalDrivingApplications1.GetFilterColum();

            string FilterText = obj.Replace("'", "''").Replace("[", "[[]").Replace("]", "[]]");
            //string columName = ctrFilterPeople1.FilterSelected();

            if (!ctrFilterLocalDrivingApplications1.FilterColumns.ContainsKey(columName))
            {
                MessageBox.Show("Invalid column selected.");
                return;
            }

            DataTable dt = clsApplications.GetAll();
            DataView dv = dt.DefaultView;

            // نحصل على نوع العمود
            Type colType = dt.Columns[columName].DataType;

            if (colType == typeof(string))
            {
                dv.RowFilter = $"[{columName}] LIKE '%{FilterText}%'";
            }
            else
            {
                dv.RowFilter = $"Convert([{columName}], 'System.String') LIKE '%{FilterText}%'";
            }
            if (columName == "None")
            {
                _ReferishGridVeiw();
            }
            dgvApplications.DataSource = dv;
            //lbNumberRecords.Text = dgvPeople.RowCount.ToString();


        }

        private void dalete_Click(object sender, EventArgs e)
        {
            clsApplications applications;
           
            if (dgvApplications.CurrentRow.Cells[6].Value.ToString()== "New")
            {
                    applications=clsApplications.Find(clsLocalDrivingLicenseApplications.Find((int)dgvApplications.CurrentRow.Cells[0].Value).AppID);
                if (MessageBox.Show("Are you ssure to cancel Application ", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    applications.AppStatus = 2;
                    if (applications.Save())
                    {
                        MessageBox.Show("Successfully  cancelled Application ", "confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ReferishGridVeiw();
                    }
                    MessageBox.Show("Failed    cancelled Application ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("The Application is Cancelled OR Completed","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void sechuleTestVisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_PassedCount != 0)
            //{
            //    visionTest.Enabled = false;
            //    return;
            //}
            int LocalID=(int)dgvApplications.CurrentRow.Cells[0].Value;
            int PassedTest = (int)dgvApplications.CurrentRow.Cells[5].Value;
            int TestTypeID =Convert.ToInt16( visionTest.Tag);
            frmVisionTestAppointments frm=new frmVisionTestAppointments(LocalID,TestTypeID);
            frm.ShowDialog();
        }

        private void sendEmail_Click(object sender, EventArgs e)
        {
            
           
        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            string Status= dgvApplications.CurrentRow.Cells[6].Value.ToString();
            _PassedCount = (int)dgvApplications.CurrentRow.Cells[5].Value;
            switch (Status)
            {
                case "Cancelled":
                    ScheduleTest.Enabled = false;
                    CancelApp.Enabled = false;
                    IssueDriving.Enabled = false;
                    ShowLicense.Enabled = false;
                    DeleteApp.Enabled = false;
                    EditApplication.Enabled = false;
                    return;
                    //break;
                case "New":
                   
                    CancelApp.Enabled = true;
                    //IssueDriving.Enabled = true;
                    //ShowLicense.Enabled = false;
                    DeleteApp.Enabled = true;
                    EditApplication.Enabled = true;
                    ScheduleTest.Enabled = true;
                   
                        ; break;
                 case "Completed":
                    ScheduleTest.Enabled = false;
                    CancelApp.Enabled = false;
                    IssueDriving.Enabled = false;
                    ShowLicense.Enabled = true;
                    DeleteApp.Enabled = false;
                    EditApplication.Enabled= false;


                     //break;
                    return;

            }

            if (_PassedCount == 2)
            {
                visionTest.Enabled = false;
                WrittenTest.Enabled = false;
                StreetTest.Enabled = true;
                IssueDriving.Enabled= false;
                ShowLicense.Enabled = false;
                return;
            }
            if (_PassedCount == 1)
            {
                visionTest.Enabled = false;
                WrittenTest.Enabled = true;
                StreetTest.Enabled = false;
                IssueDriving.Enabled= false;
                ShowLicense.Enabled = false;
                ScheduleTest.Enabled = true;
                return;
            }
            if (_PassedCount == 3&&Status=="New")
            {
               
                IssueDriving.Enabled = true;
                ShowLicense.Enabled = false;
                ScheduleTest.Enabled = false;
                EditApplication.Enabled = true;
                DeleteApp.Enabled = true;
                CancelApp.Enabled = true;

                return;
            }
            if (_PassedCount == 3)
            {
                //visionTest.Enabled = false;
                //WrittenTest.Enabled = false;
                //StreetTest.Enabled = false;
                //IssueDriving.Enabled = true;
                //ShowLicense.Enabled = true;
                ScheduleTest.Enabled = false;
                //EditApplication.Enabled = false;
                //DeleteApp.Enabled = false;
                return;
            }

            else
            {
                visionTest.Enabled = true;
                WrittenTest.Enabled = false;
                StreetTest.Enabled = false;
                IssueDriving.Enabled = false;
                ShowLicense.Enabled= false;


            }
            //_ReferishGridVeiw();
        }

        private void dgvApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            int LocalID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            frmLicenseInfo frm = new frmLicenseInfo();
            frm.FillLicenseInfoByLocalID(LocalID);
            frm.ShowDialog();
            //_ReferishGridVeiw();

        }

        private void WrittenTest_Click(object sender, EventArgs e)
        {
            int LocalID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            int PassedTest = (int)dgvApplications.CurrentRow.Cells[5].Value;
            int TestTypeID = Convert.ToInt16(WrittenTest.Tag);
            frmVisionTestAppointments frm = new frmVisionTestAppointments(LocalID, TestTypeID);
            frm.ShowDialog();
            _ReferishGridVeiw();
        }

        private void StreetTest_Click(object sender, EventArgs e)
        {
            int LocalID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            //int PassedTest = (int)dgvApplications.CurrentRow.Cells[5].Value;
            int TestTypeID = Convert.ToInt16(StreetTest.Tag);
            frmVisionTestAppointments frm = new frmVisionTestAppointments(LocalID, TestTypeID);
            frm.ShowDialog();
            _ReferishGridVeiw();

        }

        private void DeleteApp_Click(object sender, EventArgs e)
        {
            string Status = dgvApplications.CurrentRow.Cells[6].Value.ToString();
            int LocalID = (int)dgvApplications.CurrentRow.Cells[0].Value;

             int AppID = clsLocalDrivingLicenseApplications.Find(LocalID).AppID;
            if (Status == "New")
            {
                if (MessageBox.Show("Do you want to delete this application ???", "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsLocalDrivingLicenseApplications.Delete(LocalID))
                    {
                        MessageBox.Show("Deleted Successfully ");
                        clsApplications.Delete(AppID);
                    _ReferishGridVeiw();
                    }
                    else
                    {
                        MessageBox.Show("Failed Deleted  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
             
            }
            else
            {
                MessageBox.Show("Failed Deleted ,beause it is joined other table ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void IssueDriving_Click(object sender, EventArgs e)
        {
            clsApplications applications;
            int LocalID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            applications = clsApplications.Find(clsLocalDrivingLicenseApplications.Find((LocalID)).AppID);
            //if(clsLicense.is)
            frmIssueDrivingLicense frm = new frmIssueDrivingLicense(LocalID);
            frm.ShowDialog();
            applications.AppStatus = 3;
            applications.Save();
            IssueDriving.Enabled=false;
            ShowLicense.Enabled = true;
            _ReferishGridVeiw();
        }

        private int GetAppID()
        {
            int LocalID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            int AppID = clsLocalDrivingLicenseApplications.Find(LocalID).AppID;
            return AppID;
        }
        private void ShoHistory_Click(object sender, EventArgs e)
        {
            
            int driverID=clsLicense.FinByApplicationID(GetAppID()).DriverID;
            frmLicenseHistoty frm=new frmLicenseHistoty(driverID);
            frm.ShowDialog();
        }

        private void dgvApplications_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    var hitTest = dgvApplications.HitTest(e.X, e.Y);
            //    if (hitTest.RowIndex >= 0)
            //    {
            //        dgvApplications.ClearSelection();
            //        dgvApplications.Rows[hitTest.RowIndex].Selected = true;
            //        dgvApplications.CurrentCell = dgvApplications.Rows[hitTest.RowIndex].Cells[0];
            //    }
            //}
        }

        private void dgvApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            //{
            //    dgvApplications.ClearSelection(); // ألغِ أي تحديد سابق
            //    dgvApplications.Rows[e.RowIndex].Selected = true; // حدد الصف الجديد
            //    dgvApplications.CurrentCell = dgvApplications.Rows[e.RowIndex].Cells[e.ColumnIndex]; // اضبط الخلية الحالية
            //}
        }

        private void EditApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateApplications frm = new frmAddUpdateApplications(GetAppID());
            frm.ShowDialog();
        }
    }
}
