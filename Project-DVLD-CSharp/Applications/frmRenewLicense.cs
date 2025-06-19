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
    public partial class frmRenewLicense : Form
    {
        public frmRenewLicense()
        {
            InitializeComponent();
        }
        clsLicense license;
        clsApplications applications;
        private void _loadData()
        {
            ctrApplicationNewLicenseInfo1.FillRenewApplication();
        }
        private void ctrApplicationNewLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ctrInternationalLicense1_OnLicenseID(int obj)
        {
            int LicenseID=Convert.ToInt32(obj);
            license=clsLicense.Find(LicenseID);
            //btRenew.Enabled = false;

            if (license==null)
            {
                MessageBox.Show("Sorry!, license is not found  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (license.IsExpiration())
            {

                applications = clsApplications.Find(license.ApplicationID);
                ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
                ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
                btRenew.Enabled = true;
                lbkShowLicense.Enabled = true;
                lblinkShowLHistory.Enabled = true;
                return;
            }
            else
            {
                if (MessageBox.Show("Sorry!, license is not yet expired it will expire at  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    applications = clsApplications.Find(license.ApplicationID);
                    ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
                    ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
                    btRenew.Enabled = false;
                    lbkShowLicense.Enabled = true;
                    lblinkShowLHistory.Enabled = true;
                }

            }
        }
            clsApplications RenewApp= new clsApplications();
                clsLicense RenewLicense = new clsLicense();
         private void _CreateRenewLicenseApplication()
        {
            RenewApp.AppDate = DateTime.Now;
            RenewApp.AppPersonID=applications.AppPersonID;
            RenewApp.AppTypeID =Convert.ToInt32( clsApplictionsTypeTitle.GetIdByName("RenewDrivingLicenseService"));
            RenewApp.LastStatusDate = DateTime.Now; 
            RenewApp.UserID=clsUserSettings.UserID;
            RenewApp.AppStatus = 3;
            RenewApp.PaidFees=clsApplictionsTypeTitle.Find(Convert.ToInt32(clsApplictionsTypeTitle.GetIdByName("RenewDrivingLicenseService"))).fees;
            if (RenewApp.Save())
            {
                license.IsActive=false;
                if (license.Save())
                {



                    //RenewLicense = license;
                    RenewLicense.IsActive = true;
                    RenewLicense.IssueReason = 2;
                    RenewLicense.IssueDate = DateTime.Now;
                    RenewLicense.ExpirationDate = DateTime.Now.AddYears(Convert.ToInt16(clsLicenseClasses.GetInfoByID(license.LicenseClass).ValidityAge));
                    RenewLicense.ApplicationID = RenewApp.ID;
                    RenewLicense.DriverID = license.DriverID;
                    RenewLicense.Notes = license.Notes;
                    RenewLicense.PaidFees = Convert.ToInt16(clsLicenseClasses.GetInfoByID(license.LicenseClass).ClassFees);
                    RenewLicense.UserID = clsUserSettings.UserID;
                    RenewLicense.LicenseClass = license.LicenseClass;
                }
                else
                {
                    MessageBox.Show("Sorry!,Failed updated data Old License  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }



        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!license.IsExpiration())
            {
                MessageBox.Show("Sorry!,Selected license is not yet expired it will expire at  " + license.ExpirationDate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
            _CreateRenewLicenseApplication();
                if (RenewLicense.Save())
                {

                    MessageBox.Show("Save Data Successfully Renew License at  " + license.ExpirationDate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrApplicationNewLicenseInfo1.FillRenewAppIDAndRenewLicenseID(RenewLicense);
                }
                else
                {
                    MessageBox.Show("Sorry!,Failed saved data  " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            _loadData();
            lbkShowLicense.Enabled = false;
            btRenew.Enabled = false;
            lblinkShowLHistory.Enabled = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            if (this.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistoty frm=new frmLicenseHistoty(license.DriverID);
            frm.ShowDialog();
        }

        private void lbkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm=new frmLicenseInfo(license.LicenseID);
            frm.ShowDialog();
        }
    }
}
