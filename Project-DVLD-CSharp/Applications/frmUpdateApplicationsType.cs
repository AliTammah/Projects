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
    public partial class frmUpdateApplicationsType : Form
    {
        int _ApplicationID;
        clsApplictionsTypeTitle Application;
        public frmUpdateApplicationsType(int AppID)
        {
            InitializeComponent();
            _ApplicationID = AppID;
        }
        private void _LoadData()
        {
           Application=clsApplictionsTypeTitle.Find(_ApplicationID);
            lbIDUpdated.Text = _ApplicationID.ToString();
            txtFees.Text = Application.fees.ToString();
            txtTitle.Text=Application.AppName;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateApplicationsType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Application.AppName=txtTitle.Text;
            Application.fees=Convert.ToDecimal( txtFees.Text);
            if (Application.Save())
            {
                MessageBox.Show("Saved Edit Successfully");
            }
            else
            {
                MessageBox.Show("Saved Edit Successfully");

            }
        }
    }
}
