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
    public partial class ctrLicenseHistory : UserControl
    {
        public ctrLicenseHistory()
        {
            InitializeComponent();
        }
        public void referishLocalLicense(int DriverID)
        {
            dgvLocal.DataSource = clsLicense.GetAll(DriverID);
            dgvInternational.DataSource=clsInternational.GetAllByInternationalAppID(DriverID);
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID=(int)dgvLocal.CurrentRow.Cells[0].Value;
            frmLicenseInfo frm=new frmLicenseInfo(LicenseID);
            frm.ShowDialog();
        }
    }
}
