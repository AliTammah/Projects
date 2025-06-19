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
    public partial class ctrReleaseDetainLicense : UserControl
    {
        public ctrReleaseDetainLicense()
        {
            InitializeComponent();
        }

        private void ctrReleaseDetainLicense_Load(object sender, EventArgs e)
        {

        }
        public void FillReleaseDetainInfo(clsDetainedLicenses detain)
        {
            lbAppFees.Text=clsApplictionsTypeTitle.Find((int)clsApplictionsTypeTitle.GetIdByName("ReleaseDetainedDrivingLicense")).fees.ToString();
            lbFineFees.Text=detain.FineFees.ToString();
            lbDetainDate.Text=detain.DetainDate.ToString("dd-MM-yyy");  
            lbLicenseID.Text=detain.LicenseID.ToString();
            lbUserID.Text = clsUserSettings.UserName;
            lbTotalFees.Text=(detain.FineFees+Convert.ToDecimal( lbAppFees.Text)).ToString();
            lbDetainID.Text=detain.ID.ToString();
        }
        public void SetReleaseApplicationID(clsApplications ReleaseApp)
        {
            lbAppID.Text=ReleaseApp.ID.ToString();
        }
        private void lbUserID_Click(object sender, EventArgs e)
        {

        }
    }
}
