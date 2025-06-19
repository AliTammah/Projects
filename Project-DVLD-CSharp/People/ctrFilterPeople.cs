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
    public partial class ctrFilterPeople : UserControl
    {
        public ctrFilterPeople()
        {
            InitializeComponent();
        }
        public event Action<string> OnFilterPeople;

        private void OnFilterText(string text)
        {
            Action<string> filter = OnFilterPeople;
            if (filter != null)
            {
                filter(text);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string TextSearch()
        {
            return txtFilter.Text;
        }
        //public DataTable SourceData { get; set; }
        //public DataGridView TargetGrid { get; set; }
        

        public Dictionary<string,string> _FilterNames = new Dictionary<string, string>
        {
            {"None","None" },
            {"FirstName","First Name" },
            {"SecondName","Second Name" },
            {"ThirdName","Third Name" },
            {"LastName","Last Name" },
            {"PersonID","PersonID" },
            {"NationalNo","National" },
            {"Gendor","Gendor" },
            {"Phone","Phone" },
            {"Email","Email" }
        };
        private void _FillComboBox()
        {
            //if(cbFilter.Text.ToString())
            cbFilter.DataSource=new BindingSource(_FilterNames,null);
            cbFilter.DisplayMember = "Value";
            cbFilter.ValueMember = "Key";

        }
       

        public string FilterSelected()
        {
            return cbFilter.SelectedValue.ToString();
        }

        private void ctrFilterPeople_Load(object sender, EventArgs e)
        {
           _FillComboBox();

        }
        public DataView FilterPeople()
        {
            DataView dv = clspeople.GetAllPeople().DefaultView;

            string columName = FilterSelected();
            string textSearch = TextSearch().ToString();
            dv.RowFilter = $"{columName}LIKE '%{textSearch}%'";
            return dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            OnFilterText(txtFilter.Text.ToString());
    
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilter.Text.ToString() == "None")
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

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedValue.ToString() == "PersonID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
