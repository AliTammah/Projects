using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        bool CheckPassword()
        {
            if (txtConfirm.Text==txtPassword.Text)
            {
                return true;
            }
            return false;
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            if (!CheckPassword())
            {
                MessageBox.Show("Passwored is not like");
                txtPassword.Focus();
            }
        }
    }
}
