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
    public partial class frmInternationalLicenseInfo : Form
    {
        int _intID;
        clsInternational _internatinal;
        public frmInternationalLicenseInfo(int intID)
        {
            InitializeComponent();
            _intID = intID;
        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrInternationalInfo1.ShowInterNationalInfo(_intID);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrInternationalInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
