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
    public partial class frmReplacementDamagedLostLicense : Form
    {
        public frmReplacementDamagedLostLicense()
        {
            InitializeComponent();
        }
        clsLicense license;
        clsApplications applications;
        clsLicense ReplacementLicenseForDamaged;
        clsLicense ReplacementLicenseForLost;
        clsLicense CurrentLicense;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbTitle.Text = "Replacement for Damaged License";
            ctrReplaceOrLostLicenseApp1.FillReplacementAppInfo(rbDamaged.Checked);

        }

        private void frmReplacementDamagedLostLicense_Load(object sender, EventArgs e)
        {
            rbDamaged.Checked = true;
            lbkShowLicense.Enabled = false;
            btReplace.Enabled = false;
            lblinkShowLHistory.Enabled = false;
            ctrReplaceOrLostLicenseApp1.FillReplacementAppInfo(rbDamaged.Checked);
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            lbTitle.Text = "Replacement for Lost License";
            ctrReplaceOrLostLicenseApp1.FillReplacementAppInfo(rbLost.Checked);


        }

        private void ctrInternationalLicense1_OnLicenseID(int obj)
        {
            int LicenseID = Convert.ToInt32(obj);
            license = clsLicense.Find(LicenseID);
            //btRenew.Enabled = false;

            if (license == null)
            {
                MessageBox.Show("Sorry!, license is not found  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (license.ISActive())
            {

                applications = clsApplications.Find(license.ApplicationID);
                ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
                //ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
                btReplace.Enabled = true;
                lbkShowLicense.Enabled = false;
                lblinkShowLHistory.Enabled = true;
                return;
            }
            else
            {
                if (MessageBox.Show("Sorry!,Selected  license is not Active  ,Choose An Active License ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    applications = clsApplications.Find(license.ApplicationID);
                    ctrInternationalLicense1.FillUserControlLicenseInfoByLicenseID(license.LicenseID);
                    //ctrApplicationNewLicenseInfo1.FillRenewApplication2(license, applications);
                    btReplace.Enabled = false;
                    lbkShowLicense.Enabled = false;
                    lblinkShowLHistory.Enabled = true;
                }

            }


        }

        private void btReplace_Click(object sender, EventArgs e)
        {
           if(rbDamaged.Checked)
            {
            clsApplications ReplacementDamgedApp = clsApplications.CreateReplacementDamagedLicenseApp(applications);
                 ReplacementLicenseForDamaged=clsLicense.CreateAppAndLicenseReplacementDamagedLicense(license);
                ReplacementLicenseForDamaged.ApplicationID = ReplacementDamgedApp.ID;

                if (ReplacementLicenseForDamaged.Save())
                {
                   MessageBox.Show("Save Data Successfully Replacement Damaged License at  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrReplaceOrLostLicenseApp1.SetReplacementAppAndLicenseID(ReplacementDamgedApp.ID, ReplacementLicenseForDamaged.LicenseID,license.LicenseID);
                    lbkShowLicense.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Failed Saved Data Successfully Replacement Damaged License at  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                CurrentLicense=ReplacementLicenseForDamaged;
                return;
            }
            clsApplications ReplacementLostApp = clsApplications.CreateReplacementLostLicenseApp(applications);
             ReplacementLicenseForLost = clsLicense.CreateAppAndLicenseReplacementLostLicense(license);
            ReplacementLicenseForLost.ApplicationID = ReplacementLostApp.ID;

            if (ReplacementLicenseForLost.Save())
            {
                MessageBox.Show("Save Data Successfully Replacement lost License at  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrReplaceOrLostLicenseApp1.SetReplacementAppAndLicenseID(ReplacementLostApp.ID, ReplacementLicenseForLost.LicenseID,license.LicenseID);

                lbkShowLicense.Enabled = true;

            }
            else
            {
                MessageBox.Show("Failed Saved Data Successfully Replacement lost License at  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            CurrentLicense = ReplacementLicenseForLost;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbkShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(CurrentLicense.LicenseID);
            frm.ShowDialog();
        }

        private void lblinkShowLHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistoty frm=new frmLicenseHistoty(license.DriverID);
            frm.ShowDialog();
        }
    }
}
