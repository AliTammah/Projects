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
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }
        clsLicense license;
        clsApplications applications;
        clsDetainedLicenses detainedLicenses=new clsDetainedLicenses();
        private void ctrInternationalLicense1_Load(object sender, EventArgs e)
        {

        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            ctrDetainedLicenseInfo1.FillDetainLicenseInfo();
            lbkShowLicense.Enabled = false;
            btDetain.Enabled = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrInternationalLicense1_OnLicenseID(int obj)
        {
            int LicenseID = Convert.ToInt32(obj);
            license = clsLicense.Find(LicenseID);
            //detainedLicenses=clsDetainedLicenses.FindByLicenseID(LicenseID);
            //btRenew.Enabled = false;
            ctrDetainedLicenseInfo1.FillDetainLicenseInfo(license.LicenseID);

            if (license == null)
            {
                MessageBox.Show("Sorry!, license is not found  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (license.ISActive())
            //{

            //    applications = clsApplications.Find(license.ApplicationID);
            //    ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
            //    //ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
            //    btDetain.Enabled = true;
            //    lbkShowLicense.Enabled = false;
            //    lblinkShowLHistory.Enabled = true;
            //    //return;
            //}
            if (license.ISActive())
            {
                if (!license.IsReleased())
                {
                    if (MessageBox.Show("Sorry!,Selected  license is  Detained  ,Choose another License ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        applications = clsApplications.Find(license.ApplicationID);
                        ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
                        //ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
                        btDetain.Enabled = false;
                        lbkShowLicense.Enabled = false;
                        lblinkShowLHistory.Enabled = true;
                    }

                }
                else
                {
                    applications = clsApplications.Find(license.ApplicationID);
                    ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
                    //ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
                    btDetain.Enabled = true;
                    lbkShowLicense.Enabled = false;
                    lblinkShowLHistory.Enabled = true;

                }
            }
            else
            {
                if (MessageBox.Show("Sorry!,Selected  license is not Active  ,Choose An Active License ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    applications = clsApplications.Find(license.ApplicationID);
                    ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
                    //ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
                    btDetain.Enabled = false;
                    lbkShowLicense.Enabled = false;
                    lblinkShowLHistory.Enabled = true;
                }

            }
                



        }

        private void btDetain_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ctrDetainedLicenseInfo1.txtFines.Text))
            {
                errorProvider1.SetError(ctrDetainedLicenseInfo1.txtFines, "This Text box requierd,write fineFees ");
                ctrDetainedLicenseInfo1.txtFines.Focus();   
                return;
            }
            if (license.IsReleased())
            {
                detainedLicenses=clsDetainedLicenses.FindByLicenseID(license.LicenseID);
                detainedLicenses.IsReleased = false;
                detainedLicenses.FineFees=ctrDetainedLicenseInfo1.GetFineFees();    
                if (detainedLicenses.Save())
                {

                    MessageBox.Show("OK!, Saved data successfully ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrDetainedLicenseInfo1.FillDetainID(detainedLicenses.ID);
                    lbkShowLicense.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Sorry!,Failed saved Data  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            ctrDetainedLicenseInfo1.SaveData(detainedLicenses);
            if (detainedLicenses.Save())
            {
            //license.IsReleased();
                MessageBox.Show("OK!, Saved data successfully ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrDetainedLicenseInfo1.FillDetainID(detainedLicenses.ID);
                lbkShowLicense.Enabled = true;
                return;
            }
            else
            {
                MessageBox.Show("Sorry!,Failed saved Data  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lbkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(license.LicenseID);
            frm.ShowDialog();
        }

        private void lblinkShowLHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistoty frm = new frmLicenseHistoty(license.DriverID);
            frm.ShowDialog();
        }

        //private void frmDetainLicense_Leave(object sender, EventArgs e)
        //{
        //    bool allFieldsFilled = !string.IsNullOrWhiteSpace(ctrDetainedLicenseInfo1.txtFines.Text);
        //    btDetain.Enabled= allFieldsFilled;
        //}

        //private void frmDetainLicense_Validating(object sender, CancelEventArgs e)
        //{

           
        //}

        //private void btDetain_Validating(object sender, CancelEventArgs e)
        //{
        //    bool allFieldsFilled = !string.IsNullOrWhiteSpace(ctrDetainedLicenseInfo1.txtFines.Text);
        //    btDetain.Enabled = allFieldsFilled;
        //    btDetain.Focus();

        //}

        //private void btDetain_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(ctrDetainedLicenseInfo1.txtFines.Text))
        //    {
        //        errorProvider1.SetError(ctrDetainedLicenseInfo1.txtFines, "This Text box requierd,write fineFees ");
        //        //e.Cancel = true;
        //        btDetain.Enabled=false;
        //    };

        //}
    }
}
