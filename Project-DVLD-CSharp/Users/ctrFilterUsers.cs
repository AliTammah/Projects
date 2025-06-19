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
    public partial class ctrFilterUsers : UserControl
    {
        public ctrFilterUsers()
        {
            InitializeComponent();
        }
        public event Action<string> OnFilterUsers;
        private void OnFilterText(string text)
        {
            Action<string> filter = OnFilterUsers;
            if (filter != null)
            {
                filter(text);
            }
        }
        public Dictionary<string, string> ColumsNames = new Dictionary<string, string>
        {
            {"None","None" },
            {"UserName","User Name" },
            {"UserID","User ID" },
            {"PersonID","Person ID" },
            {"IsActive","Is Active" },
            {"FullName","Full Name" },
        };
        public string FilterSelected()
        {
            return cbFilter.SelectedValue.ToString();
        }
        private void _FillComboBox()
        {
            cbFilter.DataSource=new BindingSource(ColumsNames,null);
            cbFilter.DisplayMember = "Value";
            cbFilter.ValueMember = "Key";
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedValue.ToString() == "None")
            {
                txtFilter.Visible = false;
                cbFilterBy.Visible = false;
                return;
            }
          else  if (cbFilter.Text.ToString() == "Is Active")
            {
                txtFilter.Visible = false;
                cbFilterBy.Visible = true;
                cbFilterBy.Text = "";
            }
            else
            {
                txtFilter.Text = "";
                txtFilter.Visible = true;
                cbFilterBy.Visible = false;
                txtFilter.Focus();
            }
            
        }

        private void ctrFilterUsers_Load(object sender, EventArgs e)
        {
            _FillComboBox();
            //cbFilterBy.Enabled = false;
            //cbFilterBy.DropDownStyle = ComboBoxStyle.Simple;
            cbFilterBy.Items.Add("All");
            cbFilterBy.Items.Add("Yes");
            cbFilterBy.Items.Add("No");
            txtFilter.Visible = false;
        }
        public string FilterNameIsActive()
        {
            return cbFilter.Text.ToString();
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            OnFilterText(txtFilter.Text);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnFilterText(cbFilterBy.Text);
        }
    }
}
