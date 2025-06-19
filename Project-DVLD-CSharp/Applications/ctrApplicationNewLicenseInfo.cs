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
using static System.Net.Mime.MediaTypeNames;

namespace project19.Applications
{
    public partial class ctrApplicationNewLicenseInfo : UserControl
    {
        public ctrApplicationNewLicenseInfo()
        {
            InitializeComponent();
        }
       
        public void FillRenewApplication()
        {
            lbAppFees.Text=clsApplictionsTypeTitle.Find(Convert.ToInt32( clsApplictionsTypeTitle.GetIdByName("RenewDrivingLicenseService"))).fees.ToString();
            lbUserID.Text=clsUserSettings.UserName;
            lbAppDate.Text =DateTime.Now.ToString("dd-MM-yyy");


        }
        public void FillRenewApplication2(clsLicense license,clsApplications applications)
        {
            lbExpirationDate.Text=license.ExpirationDate.ToString ("dd-MM-yyy");
            lbIssueDate.Text=license.IssueDate.ToString ("dd-MM-yyy");
            txtNotes.Text=license.Notes.ToString ();
            lbOldLicenseID.Text=license.LicenseID.ToString ();
            lbLicenseFees.Text = clsLicenseClasses.GetInfoByID(license.LicenseClass).ClassFees.ToString() ;
            lbTotalFees.Text=(license.PaidFees+applications.PaidFees).ToString();
            //lbAppFees.Text=applications
        }
        public void FillRenewAppIDAndRenewLicenseID(clsLicense license)
        {
            lbIntAppID.Text=license.ApplicationID.ToString();
            lbRenewedID.Text=license.LicenseID.ToString();  
        }
    }
}
