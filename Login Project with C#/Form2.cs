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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btNext_MouseDown(object sender, MouseEventArgs e)
        {
            btNext.BackColor = Color.Purple;
        }

        private void btNext_MouseHover(object sender, EventArgs e)
        {
            btNext.BackColor = Color.Purple;
        }

        private void btNext_MouseUp(object sender, MouseEventArgs e)
        {
            btNext.BackColor = Color.Purple;
        }

        private void btBack_MouseUp(object sender, MouseEventArgs e)
        {
            btBack.BackColor=Color.Purple;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
           /* Form form = new Form1();
            form.Show();*/
            this.Close();
                

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            Form form=new Form3();
            form.Show();
        }
    }
}
