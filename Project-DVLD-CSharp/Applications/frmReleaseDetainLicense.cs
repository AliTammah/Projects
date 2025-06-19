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
    public partial class frmReleaseDetainLicense : Form
    {
        public frmReleaseDetainLicense()
        {
            InitializeComponent();
        }
        clsLicense license;
        clsDetainedLicenses detainedLicenses;
        clsApplications applications;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrInternationalLicense1_OnLicenseID(int obj)
        {
            int LicenseID = Convert.ToInt32(obj);
            license = clsLicense.Find(LicenseID);
            detainedLicenses = clsDetainedLicenses.FindByLicenseID(LicenseID);
            //btRenew.Enabled = false;
            ctrReleaseDetainLicense1.FillReleaseDetainInfo(detainedLicenses);

            if (license == null)
            {
                MessageBox.Show("Sorry!, license is not found  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (license.ISActive())
            {
                if (detainedLicenses.IsReleased)
                {
                    if (MessageBox.Show("Sorry!,Selected  license is not Detained  ,Choose another License ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        applications = clsApplications.Find(license.ApplicationID);
                        ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
                        //ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
                        btRelease.Enabled = false;
                        lbkShowLicense.Enabled = false;
                        lblinkShowLHistory.Enabled = true;
                    }

                }
                else {
                    applications = clsApplications.Find(license.ApplicationID);
                    ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
                //ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
              btRelease.Enabled = true;
                    lbkShowLicense.Enabled = false;
                    lblinkShowLHistory.Enabled = true;
                    //return;
                }
            }
            else
            {
                if (MessageBox.Show("Sorry!,Selected  license is not Active  ,Choose An Active License ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    applications = clsApplications.Find(license.ApplicationID);
                    ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
                    //ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
                    btRelease.Enabled = false;
                    lbkShowLicense.Enabled = false;
                    lblinkShowLHistory.Enabled = true;
                }
            } 
        }
        bool isDisablle=false;

        public void SetLicenseID(int licenseID)
        {
            ctrInternationalLicense1_OnLicenseID(licenseID);
            btRelease.Enabled = true;
        isDisablle=    ctrInternationalLicense1.DisablleFilter(licenseID);

        }
            
            clsApplications releaseApp= new clsApplications();
        private void CreateReleaseApplication()
        {
            releaseApp.AppDate= DateTime.Now;
            releaseApp.AppPersonID = applications.AppPersonID;
            releaseApp.AppTypeID =(int) clsApplictionsTypeTitle.GetIdByName("ReleaseDetainedDrivingLicense");
            releaseApp.AppStatus = 3;
            releaseApp.PaidFees=clsApplictionsTypeTitle.Find((int)clsApplictionsTypeTitle.GetIdByName("ReleaseDetainedDrivingLicense")).fees;
            releaseApp.UserID = clsUserSettings.UserID;
            releaseApp.LastStatusDate = DateTime.Now;
            if (releaseApp.Save())
            {
                MessageBox.Show("OK!, Saved data Application successfully ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                MessageBox.Show("Error!,Failed Saved Application data successfully ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btDetain_Click(object sender, EventArgs e)
        {
            CreateReleaseApplication();
            //ctrReleaseDetainLicense1.
            detainedLicenses.IsReleased = true;
            detainedLicenses.ReleaseApplicationID = releaseApp.ID;
            detainedLicenses.ReleaseDate=releaseApp.AppDate;
            detainedLicenses.ReleasedByUserID = clsUserSettings.UserID;
            if (detainedLicenses.Save())
            {

                MessageBox.Show("OK!, Saved data successfully ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrReleaseDetainLicense1.SetReleaseApplicationID(releaseApp);
               lbkShowLicense.Enabled = true;
                return;

            }
            else
            {
                MessageBox.Show("Error!,Failed Saved detain release data  ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmReleaseDetainLicense_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            if (this.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            }
            if (isDisablle)
            {

            btRelease.Enabled = true;
                return ;
            }
            btRelease.Enabled = false;
                lbkShowLicense.Enabled = false;


        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(detainedLicenses.LicenseID);
            frm.ShowDialog();
        }

        private void lblinkShowLHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistoty frm=new frmLicenseHistoty(license.DriverID);
            frm.ShowDialog();
        }

        private void ctrInternationalLicense1_Load(object sender, EventArgs e)
        {

        }
    }
}
