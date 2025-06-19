using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }
        bool CheckYear()
        {
            DateTime dateTime = DateTime.UtcNow;
            if (dateTime.Year- Convert.ToSingle(txtYear.Text)<=18)
            {
                return false;
            }
            return true;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

       

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (!CheckYear())
            {
                MessageBox.Show("Sorry!,This age Can not Allow");
                txtYear.Focus();
               
            } 
            Form form= new Form4();
                form.Show();
        }

      
    }
}
