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
    public partial class ctrFilterLocalDrivingApplications : UserControl
    {
        public ctrFilterLocalDrivingApplications()
        {
            InitializeComponent();
        }
        public event Action<string> OnFilterLocalApplications;

        private void OnFilterText(string text)
        {
            Action<string> filter = OnFilterLocalApplications;
            if (filter != null)
            {
                filter(text);
            }
        }
        public DataTable SourceData { get; set; }
        public DataGridView TargetGrid { get; set; }
        private Dictionary<string, string> _filterColumns;
        public Dictionary<string, string> FilterColumns
        {
            get { return _filterColumns; }
            set
            {
                _filterColumns = value;
                PopulateFilterComboBox();
            }
        }
        bool isBinding=false;
        private void PopulateFilterComboBox()
        {
            if (_filterColumns != null && cbFilter != null)
            {
                //cbFilter.SelectedIndex = 0;
                isBinding = true;
                cbFilter.DataSource = new BindingSource(_filterColumns, null);
                cbFilter.DisplayMember = "Value"; // الاسم المعروض
                cbFilter.ValueMember = "Key";   
                isBinding = false;
                // اسم العمود الفعلي
                cbFilter.SelectedIndex = 0;
            }
        }
        public string GetFilterText()
        {
            return txtFilter.Text.ToString();
        }
        public string GetFilterColum()
        {

            return cbFilter.SelectedValue.ToString();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isBinding)
                return;
            if (cbFilter.SelectedValue.ToString() == "None")
            {
                txtFilter.Visible = false;
            }
            else
            {
                txtFilter.Text = "";
                txtFilter.Visible = true;
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            OnFilterText(txtFilter.Text.ToString());
        }

        private void ctrFilterLocalDrivingApplications_Load(object sender, EventArgs e)
        {
            txtFilter.Visible=false;
            //cbFilter.SelectedIndex = ;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
