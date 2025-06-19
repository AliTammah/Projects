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
    public partial class frmManageTestsTypes : Form
    {
        public frmManageTestsTypes()
        {
            InitializeComponent();
        }
        private void _ReferishDataGridVeiw()
        {
            dgvTestType.DataSource = clsTestsTypes.GetAll();
            lbNumberRecords.Text=dgvTestType.RowCount.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageTestsTypes_Load(object sender, EventArgs e)
        {
            _ReferishDataGridVeiw();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdateTestTypes fr=new frmUpdateTestTypes((int)dgvTestType.CurrentRow.Cells[0].Value);  
            fr.ShowDialog();
            _ReferishDataGridVeiw();
        }
    }
}
