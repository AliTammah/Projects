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
    public partial class ctrLicenseInfo : UserControl
    {
        int _LocalID;
        int _PersonID;  
        clsLicense _license;
        clspeople _people;
        public ctrLicenseInfo()
        {
            InitializeComponent();
        }
        public void FillCTRLicensInfo(int LocalID)
        {
            _LocalID = LocalID;
            _license = clsLicense.LicenseInfo(_LocalID);
            _PersonID = clsApplications.Find(_license.ApplicationID).AppPersonID;
            _people = clsLicense.GetInfoPerson(_PersonID);

            lbClass.Text=clsLicense.GetClassName(_LocalID);
            lbName.Text=_people.FullName;
            //lbGendor.Text = _people.Gender.ToString();
            if (_people.Gender == 1)
            {
                lbGendor.Text = "Male";
            }
            else
            {
                lbGendor.Text = "Female";
            }
            //lbIssueReason.Text=_license.IssueReason
            if (_license.IsActive)
            {
                lbIsActive.Text = "Yes";
            }
            else
            {
                lbIsActive.Text = "No";
            }
            if (_license.IsReleased())
            {
                lbDetained.Text = "Yes";
            }
            else
            {
                lbDetained.Text = "No";
            }
            lbIssueDate.Text = _license.IssueDate.ToString("dd-MM-yyy");
            lbIssueReason.Text= _license.IssueReason.ToString();
            lbNational.Text=_people.National.ToString();
            lbDatOFBirth.Text=_people.DateOfBirth.ToString("dd-MM-yyy");
            lbDriverID.Text=_license.DriverID.ToString();
            lbExpirationDate.Text=_license.ExpirationDate.ToString("dd-MM-yyy");
            lbLicenseID.Text=_license.LicenseID.ToString(); 
            lbNotes.Text=_license.Notes.ToString();
            if (_people.ImagePath != null)
            {
                pbImage.Load(_people.ImagePath);
            }
            else
            {
                pbImage.Image = null;
            }
            lbIssueReason.Text = _license.GetIssueReason().ToString();

        } 
        public void FillCTRLicensInfoBylicenseID(int LicenseID)
        {
            //_LocalID = LocalID;
            _license = clsLicense.Find(LicenseID);
            _PersonID = clsApplications.Find(_license.ApplicationID).AppPersonID;
            _people = clsLicense.GetInfoPerson(_PersonID);

            lbClass.Text=clsLicenseClasses.GetInfoByID(_license.LicenseClass).ClassName;
            lbName.Text=_people.FullName;
            //lbGendor.Text = _people.Gender.ToString();
            if (_people.Gender == 1)
            {
                lbGendor.Text = "Male";
            }
            else
            {
                lbGendor.Text = "Female";
            }
            //lbIssueReason.Text=_license.IssueReason
            if (_license.IsActive)
            {
                lbIsActive.Text = "Yes";
            }
            else
            {
                lbIsActive.Text = "No";
            }
            if (!_license.IsReleased())
            {
                lbDetained.Text = "Yes";
            }
            else
            {
                lbDetained.Text = "No";
            }
            lbIssueDate.Text = _license.IssueDate.ToString("dd-MM-yyy");
            lbIssueReason.Text= _license.IssueReason.ToString();
            lbNational.Text=_people.National.ToString();
            lbDatOFBirth.Text=_people.DateOfBirth.ToString("dd-MM-yyy");
            lbDriverID.Text=_license.DriverID.ToString();
            lbExpirationDate.Text=_license.ExpirationDate.ToString("dd-MM-yyy");
            lbLicenseID.Text=_license.LicenseID.ToString(); 
            lbNotes.Text=_license.Notes.ToString();
            if (_people.ImagePath != null)
            {
                pbImage.Load(_people.ImagePath);
            }
            else
            {
                pbImage.Image = null;
            }
            lbIssueReason.Text = _license.GetIssueReason().ToString();

        }
        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
    }
}
