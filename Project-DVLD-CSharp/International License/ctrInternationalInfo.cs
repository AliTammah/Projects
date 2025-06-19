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

namespace project19.International_License
{
    public partial class ctrInternationalInfo : UserControl
    {
        public ctrInternationalInfo()
        {
            InitializeComponent();
        }
        clsInternational international;
        clsLicense license;
        clspeople person;
        private void lbClass_Click(object sender, EventArgs e)
        {

        }
        public void ShowInterNationalInfo(int IntID)
        {
            international=clsInternational.Find(IntID);
            license=clsLicense.Find(international.IssuedUsingLocalLicenseID);
            person=clspeople.Find(clsApplications.Find(international.ApplicationID).AppPersonID);
            lbName.Text=person.FullName;
            lbLicenseID.Text = international.IssuedUsingLocalLicenseID.ToString();
            lbNational.Text=person.National;
            lbIssueDate.Text=international.IssuedUsingLocalLicenseID.ToString("dd-MM-yyy");
            lbExpirationDate.Text=international.ExpirationDate.ToString("dd-MM-yyy");
            //lbGendor.Text = _people.Gender.ToString();
            if (person.Gender == 1)
            {
                lbGendor.Text = "Male";
            }
            else
            {
                lbGendor.Text = "Female";
            }
            //lbIssueReason.Text=_license.IssueReason
            if (international.IsActive)
            {
                lbIsActive.Text = "Yes";
            }
            else
            {
                lbIsActive.Text = "No";
            }
           
            lbDatOFBirth.Text=person.DateOfBirth.ToString("dd-MM-yyy");
            lbDriverID.Text=international.DriverID.ToString();
            lbIntLicenseID.Text=international.InternationalLicenseID.ToString();
            lbAppID.Text=international.ApplicationID.ToString();
            if (person.ImagePath != null)
            {
                pbImage.Load(person.ImagePath);
            }
            else
            {
                person.ImagePath = null;
            }
        }

        private void ctrInternationalInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
