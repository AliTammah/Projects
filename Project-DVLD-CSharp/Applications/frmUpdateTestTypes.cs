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
    public partial class frmUpdateTestTypes : Form
    {
        int _TestID;
        clsTestsTypes _TestType;
        public frmUpdateTestTypes(int TestID)
        {
            InitializeComponent();
            _TestID = TestID;
        }
        private void _LoadData()
        {
            _TestType=clsTestsTypes.Find(_TestID);
            lbIDUpdated.Text = _TestID.ToString();
            txtDescription.Text = _TestType.TestDescription.ToString();
            txtTitle.Text = _TestType.TestType;
            txtFees.Text = _TestType.TestFees.ToString();

        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _TestType.TestType=txtTitle.Text;
            _TestType.TestFees=Convert.ToDecimal( txtFees.Text);
            _TestType.TestDescription=txtDescription.Text;
            _TestType.TestID= _TestID;
            if (_TestType.Save())
            {
                MessageBox.Show("Saved edit Successfully");
            }
            else
            {
                MessageBox.Show("Failed Saved edit Successfully");

            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
