using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusnissLayer;

namespace project19
{
    public partial class frmAddUpdateInternational : Form
    {
        int _LicenseID ;
        clsInternational _international=new clsInternational();
        public frmAddUpdateInternational()
        {
            InitializeComponent();
        }
        clsLicense _license;
        int LicenseID;
        int _LocalID;
        private void _LoadData()
        {
            _LicenseID = ctrInternationalLicense1.GetLicenseID();
        }

        private void ctrInternationalLicense1_Load(object sender, EventArgs e)
        {

        }

        private void ctrLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmAddUpdateInternational_Load(object sender, EventArgs e)
        {
            ctrLicenseApplicationInfo1.FillApplicationInfo();
            lbkShowLicense.Enabled = false;
            //_LoadData();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _SaveData()
        {
            ctrLicenseApplicationInfo1.SaveApplicationInfoToObject(_international);
            ctrInternationalLicense1.SaveDataInterNational(_international);

        }
        private void btSave_Click(object sender, EventArgs e)
        {
            _SaveData();
            if (!ctrInternationalLicense1.IsExist())
            {
                if (_international.Save())
                {
                    MessageBox.Show("Saved Data Successfully ");
                    ctrLicenseApplicationInfo1.FillInternationalLicenseID(_international);
                    lbkShowLicense.Enabled = true;
                }
                else
                {
                    MessageBox.Show("failed Saved Data  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("This Person have International license Active   ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frm=new frmInternationalLicenseInfo(_international.InternationalLicenseID);
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistoty frm=new frmLicenseHistoty(_international.ApplicationID);
            frm.ShowDialog();

        }

        private void ctrInternationalLicense1_OnLicenseID(int obj)
        {
            _license = clsLicense.Find(obj);
            _LocalID = _license.GetLocalID();
            if (_license == null)
            {
                MessageBox.Show("This License Not found  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsLicenseClasses.GetInfoByID(_license.LicenseClass).ClassID != 3)
            {
                MessageBox.Show("This license class is not type class3   ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_license.IsActive)
            {
                //_LocalID = _license.GetLocalID();
                ctrInternationalLicense1.FillUserControlLicenseInfo(_LocalID);
                return;
            }
            else
            {
                MessageBox.Show("This license  local  license is not Active  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
