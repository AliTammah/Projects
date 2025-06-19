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
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();
        }
        private void _ReferishGridView()
        {
            dgvDrivers.DataSource=clsDrivers.GetAllFromDriversView();
            lbNumberRecords.Text=dgvDrivers.Rows.Count.ToString();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _ReferishGridView();
            _loadData();
        }
        private Dictionary<string,string>FilterColum=new Dictionary<string, string> {

            {"None","None" },
            {"DriverID","Driver ID" },
            {"PersonID","Person ID" },
            {"NationalNo","National No" },
            {"FullName","Full Name" }
        
        
        };
        private void _loadData()
        {
            ctrFilterLocalDrivingApplications1.FilterColumns=FilterColum;
        }

        private void ctrFilterLocalDrivingApplications1_OnFilterLocalApplications(string obj)
        {
            string columName = ctrFilterLocalDrivingApplications1.GetFilterColum();

            string FilterText = obj.Replace("'", "''").Replace("[", "[[]").Replace("]", "[]]");
            //string columName = ctrFilterPeople1.FilterSelected();

            if (!ctrFilterLocalDrivingApplications1.FilterColumns.ContainsKey(columName))
            {
                MessageBox.Show("Invalid column selected.");
                return;
            }

            DataTable dt = clsDrivers.GetAllFromDriversView();
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
            if (columName == "None")
            {
                _ReferishGridView();
            }
            dgvDrivers.DataSource = dv;
            //lbNumberRecords.Text = dgvPeople.RowCount.ToString();


        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
