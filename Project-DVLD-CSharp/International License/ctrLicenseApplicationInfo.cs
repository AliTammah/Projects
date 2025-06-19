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
    public partial class ctrLicenseApplicationInfo : UserControl
    {
        public ctrLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        clsLicense _license;
        clsApplications _application;
        private void lbNatio_Click(object sender, EventArgs e)
        {

        }
        public void FillApplicationInfo()
        {
            //_license=clsLicense.Find(LicenseID);
            //int App=_license.ApplicationID;
            //_application= clsApplications.Find(App);
            lbFees.Text=clsApplictionsTypeTitle.Find(Convert.ToInt32( clsApplictionsTypeTitle.GetIdByName("RenewDrivingLicenseService"))).fees.ToString();
            //lbAppDate.Text=_application.AppDate.ToString    ();
            lbIssueDate.Text=DateTime.Now.ToString("dd-MM-yy");
            lbUserID.Text=clsUserSettings.UserName;
            lbExpirationDate.Text=DateTime.Now.AddYears(1).ToString("dd-MM-yy");

            //lb
        }
        public void SaveApplicationInfoToObject(clsInternational international)
        {
            international.ExpirationDate =Convert.ToDateTime( lbExpirationDate.Text);
            international.IssueDate= Convert.ToDateTime(lbIssueDate.Text);
            international.CreatedByUserID=clsUserSettings.UserID;

        }
        public void FillInternationalLicenseID(clsInternational international)
        {
           lbIntAppID.Text=international.ApplicationID.ToString();
            lbIntLicenseID.Text=international.InternationalLicenseID.ToString();
            lbLocalID.Text=international.IssuedUsingLocalLicenseID.ToString();
            lbAppDate.Text=clsApplications.Find(international.ApplicationID).AppDate.ToString();
        }
        private void ctrLicenseApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pbMaleORFemale_Click(object sender, EventArgs e)
        {

        }
    }
}
