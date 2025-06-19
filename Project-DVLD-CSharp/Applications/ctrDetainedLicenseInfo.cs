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
    public partial class ctrDetainedLicenseInfo : UserControl
    {
        public ctrDetainedLicenseInfo()
        {
            InitializeComponent();
        }
        public void FillDetainLicenseInfo(int ?LicenseID=null)
        {
            lbDetainDate.Text = DateTime.Now.ToString("dd-MM-yyy");
            lbUserID.Text = clsUserSettings.UserName;
            lbLicenseID.Text=LicenseID.ToString();

        }
        public void FillDetainID(int DetainID)
        {
            lbDetainID.Text = DetainID.ToString();  
        }
        public void SaveData(clsDetainedLicenses detain)
        {
            detain.DetainDate = Convert.ToDateTime(lbDetainDate.Text);
            detain.FineFees= Convert.ToDecimal(txtFines.Text);
            detain.CreatedByUserID = clsUserSettings.UserID;
            detain.LicenseID = Convert.ToInt32(lbLicenseID.Text);
            detain.IsReleased = false;
                
        }
        public decimal GetFineFees()
        {
            return Convert.ToDecimal(txtFines.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtFines_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFines.Text))
            {
                errorProvider1.SetError(txtFines,"This Text box requierd,write fineFees ");
                e.Cancel = true;
            }
        }

        private void txtFines_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFines.Text))
            {
                errorProvider1.SetError(txtFines, "This Text box requierd,write fineFees ");
                txtFines.Focus();

            }
        }
    }
}
