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

namespace project19.Applications
{
    public partial class frmMmanageDetainLicense : Form
    {
        public frmMmanageDetainLicense()
        {
            InitializeComponent();
        }

        private void frmMmanageDetainLicense_Load(object sender, EventArgs e)
        {
            FillComboBox();
            _ReferishGridVeiw();
        }

        private void lbManagePeople_Click(object sender, EventArgs e)
        {

        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm= new frmDetainLicense();
            frm.ShowDialog();
        }
        private void _ReferishGridVeiw()
        {
            dgvDetainedLicenses.DataSource = clsDetainedLicenses.GetAll();
            lbNumberRecords.Text=dgvDetainedLicenses.RowCount.ToString();
        }
        private void FillComboBox()
        {
           var FilterNames=new Dictionary<string, string>
           {
               {"None","None" },
               {"DetainID","Detain ID" },
               {"IsReleased","Is Released" },
               {"NationalNo","National No" },
               {"FullName","Full Name" },
               {"ReleaseApplicationID"," Release Application ID" }
           };
            ctrFilterLocalDrivingApplications1.FilterColumns = FilterNames;
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

            DataTable dt = clsDetainedLicenses.GetAll();
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
            dgvDetainedLicenses.DataSource = dv;
            //lbNumberRecords.Text = dgvPeople.RowCount.ToString();


        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainLicense frm=new frmReleaseDetainLicense();
            frm.ShowDialog();

        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int Driver=clsLicense.Find((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value).DriverID;
            int personID = clsDrivers.Find(Driver).PersonID;
            frmPersonDetails frm = new frmPersonDetails(personID);
            frm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            frmLicenseInfo frm=new frmLicenseInfo(LicenseID);
            frm.ShowDialog();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = clsLicense.Find((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value).DriverID;
            frmLicenseHistoty frm=new frmLicenseHistoty(DriverID);
            frm.ShowDialog();
        }
        clsLicense license;
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            license = clsLicense.Find((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            if (license.IsReleased())
            {
                releaseDetainsLicenseToolStripMenuItem.Enabled = false;
            }
            else
            {
                releaseDetainsLicenseToolStripMenuItem.Enabled = true;
                return;
            }

        }

        private void releaseDetainsLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;

            frmReleaseDetainLicense frm = new frmReleaseDetainLicense();
            frm.SetLicenseID(LicenseID);
            frm.ShowDialog();
            _ReferishGridVeiw();
        }
    }
}
