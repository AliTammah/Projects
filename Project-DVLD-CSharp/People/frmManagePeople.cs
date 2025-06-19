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
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }
        private void _ReferishPeopleLis()
        {
            //DataView dv = new DataView();
            dgvPeople.DataSource=clspeople.GetAllPeople();
            //dv =clspeople.GetAllPeople().DefaultView;
            //DataView dv=dgvPeople
            //if (dv != null)
            //{
            //    return;
            //}
            //if(ctrFilterPeople1.FilterName().ToString())
            //dv.RowFilter=ctrFilterPeople1.FilterName().ToString();
            lbNumberRecords.Text = dgvPeople.RowCount.ToString();


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm=new frmAddUpdatePerson(-1);
            frm.ShowDialog();
            _ReferishPeopleLis();
            lbNumberRecords.Text = dgvPeople.RowCount.ToString();

        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _ReferishPeopleLis();
            lbNumberRecords.Text=dgvPeople.RowCount.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void showDetails_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm=new frmPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            //_ReferishPeopleLis();
        }

        private void editPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _ReferishPeopleLis();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete contact [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (clspeople.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show(" Delete Person Successfully");
                    _ReferishPeopleLis();
                }
                else
                {
                    MessageBox.Show("Can not delete Person");
                }
            }
        }

        private void ctrFilterPeople1_OnFilterPeople(string obj)
        {
            string FilterText = obj.Replace("'", "''").Replace("[", "[[]").Replace("]", "[]]");
            string columName = ctrFilterPeople1.FilterSelected();

            if (!ctrFilterPeople1._FilterNames.ContainsKey(columName))
            {
                MessageBox.Show("Invalid column selected.");
                return;
            }

            DataTable dt = clspeople.GetAllPeople();
            DataView dv = dt.DefaultView;

            // نحصل على نوع العمود
            Type colType = dt.Columns[columName].DataType;

            if (colType == typeof(string))
            {
                dv.RowFilter = $"[{columName}] LIKE '%{FilterText}%'";
            }
            else
            {
                dv.RowFilter = $"Convert([{columName}], 'System.String') LIKE '%{FilterText}%'";
            }

            dgvPeople.DataSource = dv;
            lbNumberRecords.Text = dgvPeople.RowCount.ToString();

        }

        private void ctrFilterPeople1_Load(object sender, EventArgs e)
        {

        }

        private void lbRecords_Click(object sender, EventArgs e)
        {

        }

        private void lbNumberRecords_Click(object sender, EventArgs e)
        {

        }
    }
}
