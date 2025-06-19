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
    public partial class frmManageInternationalLicense : Form
    {
        public frmManageInternationalLicense()
        {
            InitializeComponent();
        }
        private void _RefirshInternational()
        {
            dgvInternational.DataSource = clsLicense.GetAllInternational();
            lbNumberRecords.Text=dgvInternational.RowCount.ToString();
        }
        private void _LoadData()
        {
            var  ColumsFilter = new Dictionary<string, string> {


            {"None","None " },
            {"ApplicationID","Application ID" },
            {"DriverID","Driver ID" },
            {"IssuedUsingLocalLicenseID","License ID" },
            {"InternationalLicenseID","International license ID" }
            //{"ApplicationID","Applicatin ID" },
        
        };
        ctrFilterLocalDrivingApplications1.FilterColumns=ColumsFilter;

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void frmManageInternationalLicense_Load(object sender, EventArgs e)
        {
            _RefirshInternational();
            _LoadData();
        }

        private void ctrFilterLocalDrivingApplications1_OnFilterLocalApplications(string obj)
        {
            string columName = ctrFilterLocalDrivingApplications1.GetFilterColum();

            string FilterText = obj.Replace("'", "''").Replace("[", "[[]").Replace("]", "[]]");
            //string columName = ctrFilterPeople1.FilterSelected();

            if (!ctrFilterLocalDrivingApplications1.FilterColumns.ContainsKey(columName))
            {
                MessageBox.Show("Invalid column selected.");
                return;
            }

            DataTable dt = clsLicense.GetAllInternational();
            DataView dv = dt.DefaultView;

            // نحصل على نوع العمود
            Type colType = dt.Columns[columName].DataType;
            if (columName == "None")
            {

                _RefirshInternational();
                return;
            }

            if (colType == typeof(string))
            {
                dv.RowFilter = $"[{columName}] LIKE '%{FilterText}%'";
            }
            else
            {
                dv.RowFilter = $"Convert([{columName}], 'System.String') LIKE '%{FilterText}%'";
            }
           
            dgvInternational.DataSource = dv;
            //lbNumberRecords.Text = dgvPeople.RowCount.ToString();

        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int IntID=Convert.ToInt32(dgvInternational.CurrentRow.Cells[0].Value);
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(IntID);
            frm.ShowDialog();
           
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateInternational frm=new frmAddUpdateInternational();
            frm.ShowDialog();
            _RefirshInternational();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppID=Convert.ToInt32(dgvInternational.CurrentRow.Cells [1].Value);
            frmLicenseHistoty frm=new frmLicenseHistoty(AppID);
            frm.ShowDialog ();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PaersonID = clsApplications.Find((int)dgvInternational.CurrentRow.Cells[1].Value).AppPersonID;
            frmPersonDetails frm=new frmPersonDetails(PaersonID);
            frm.ShowDialog();
        }
    }
}
