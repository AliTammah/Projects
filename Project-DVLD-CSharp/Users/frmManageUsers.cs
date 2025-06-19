using DataBusnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project19
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }
        clspeople person;
        private DataTable _NewGridVeiw()
        {
            DataTable dt = clsUsers.GetAll();
            //SqlDataAdapter da=new SqlDataAdapter();
            //dgvUsers.DataSource = dt;
            dt.Columns.Add("FullName", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                person = clspeople.Find((int)row[1]);
                string FullName = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                row["FullName"] = FullName;
            }
            //dt.Rows.Remove("Password");
            return dt;
        }
        private void _RefrishDataGridVeiw()
        {
            //DataTable dt = _NewGridVeiw();
            
            //dgvUsers.Columns.
            dgvUsers.DataSource = _NewGridVeiw();
            dgvUsers.Columns.Remove("Password");
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefrishDataGridVeiw();

        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(-1);
            frm.ShowDialog();
            _RefrishDataGridVeiw();
        }

        private void editPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrishDataGridVeiw();
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser(-1);
            frm.ShowDialog();
            _RefrishDataGridVeiw();

        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrishDataGridVeiw();
        }

        private void showDetails_Click(object sender, EventArgs e)
        {
            frmShowInfoUsers frm = new frmShowInfoUsers((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dalete_Click(object sender, EventArgs e)
        {
            clsUsers.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            _RefrishDataGridVeiw();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ctrFilterUsers1_OnFilterUsers(string obj)
        {
            string FilterText = obj.Replace("'", "''").Replace("[", "[[]").Replace("]", "[]]");
            string columName = ctrFilterUsers1.FilterSelected();

            if (!ctrFilterUsers1.ColumsNames.ContainsKey(columName))
            {
                MessageBox.Show("Invalid column selected.");
                return;
            }

            DataTable dt = _NewGridVeiw();
            DataView dv = dt.DefaultView;

            // نحصل على نوع العمود
            Type colType = dt.Columns[columName].DataType;

            if (colType == typeof(string))
            {
                dv.RowFilter = $"[{columName}] LIKE '%{FilterText}%'";
            }
            else
            {
                if (FilterText == "Yes")
                {

                    dv.RowFilter = $"Convert([{columName}], 'System.String') LIKE '%{true}%'";
                }
                if (FilterText == "No")
                {
                    dv.RowFilter = $"Convert([{columName}], 'System.String') LIKE '%{false}%'";

                }
                else
                {
                    dv.RowFilter = $"Convert([{columName}], 'System.String') LIKE '%{FilterText}%'";

                }
            }

            _RefrishDataGridVeiw();
        }

        private void ctrFilterUsers1_OnFilterUsers_1(string obj)
        {
            string FilterText = obj.Replace("'", "''").Replace("[", "[[]").Replace("]", "[]]");
            string columName = ctrFilterUsers1.FilterSelected();

            if (!ctrFilterUsers1.ColumsNames.ContainsKey(columName))
            {
                MessageBox.Show("Invalid column selected.");
                return;
            }

            DataTable dt = _NewGridVeiw();
            DataView dv = dt.DefaultView;
            if (columName == "FullName")
            {
                dv.RowFilter = $"[{columName}] LIKE '%{FilterText}%'";

            }
            // نحصل على نوع العمود
            Type colType = dt.Columns[columName].DataType;

            if (colType == typeof(string))
            {
                dv.RowFilter = $"[{columName}] LIKE '%{FilterText}%'";
            }
          else  if (colType == typeof(int))
            {
                dv.RowFilter = $"Convert([{columName}], 'System.String') LIKE '%{FilterText}%'";


            }
            else
            {
                if (FilterText == "Yes")
                {

                    dv.RowFilter = $"Convert([{columName}], 'System.String') LIKE '%{true}%'";
                }
                else if (FilterText == "No")
                {
                    dv.RowFilter = $"Convert([{columName}], 'System.String') LIKE '%{false}%'";

                }
                else
                {
                    //dv.RowFilter = $"Convert([{columName}], 'System.String') LIKE '%{" "}%'";
                    dgvUsers.DataSource = dv;

                    //_RefrishDataGridVeiw();
                }
            }
            dgvUsers.DataSource= dv;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
