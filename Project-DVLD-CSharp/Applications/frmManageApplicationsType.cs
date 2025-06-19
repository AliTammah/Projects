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
    public partial class frmManageApplicationsType : Form
    {
        public frmManageApplicationsType()
        {
            InitializeComponent();

        }
        private void _ReferishDataGridVeiw()
        {
            dgvApplicationsType.DataSource=clsApplictionsTypeTitle.GetAll();
            lbNumberRecords.Text=dgvApplicationsType.RowCount.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageApplicationsType_Load(object sender, EventArgs e)
        {
            _ReferishDataGridVeiw();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationsType frm=new frmUpdateApplicationsType((int)dgvApplicationsType.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _ReferishDataGridVeiw();
        }
    }
}
