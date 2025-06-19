using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //   label1.Text = textBox1.Text;
           

              //  textBox1.Text = Calculate();
            
            
        }
        void AddOpiration(Button button)
        {

            if ( CheckDoubleOperation(button))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1,1);
                textBox1.Text += button.Text;
                return;
            }
            if (CheckOPeration(button))
            {
                textBox1.Text += button.Text;
                   
            }
           
            if (CheckOpiration())
            {

                //textBox1.Text = Calculate();
                label1.Text = Calculate();
            }

        }
        bool CheckDoubleOperation(Button button)
        {
            string b = textBox1.Text;
            if (!char.IsDigit(Convert.ToChar(button.Text))&&!char.IsDigit((textBox1.Text.Last())))
            {
              return true;  
            }
            return false;
        }
        string Calculate()
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            return dt.Compute(textBox1.Text, "").ToString();
        }
        private void button_Click(object sender, EventArgs e)
        {
            AddOpiration((Button)sender);
            

        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            if (CheckOpiration())
            {

                textBox1.Text = Calculate();
                label1.Text = Calculate();
            }
            else
            {
                textBox1.Clear();
            }

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }
        bool CheckOPeration(Button button)
        {
            if (textBox1.Text==""&&button.Text=="*")
            {
                MessageBox.Show("You can not start with operation");
                return false;
            }
            if (textBox1.Text==""&&button.Text=="/")
            {
                MessageBox.Show("You can not start with operation");
                return false ;
            }
            return true;
        }
        bool FindOperation(string op)
        {
            if (op.Contains("*")|| op.Contains("/")|| op.Contains("+")|| op.Contains("-"))
            {
                return true;    
            }
            return false;
        }
        bool CheckOpiration()
        {
            string SS = textBox1.Text;
            if (char.IsDigit(SS[0]) && char.IsDigit(SS[SS.Length - 1]))
            {
                return true;
            }
            return false;
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            textBox1.Text= textBox1.Text.Remove( textBox1.Text.Length-1,1);
            if (string.IsNullOrEmpty(textBox1.Text))
                return;
            
            if (CheckOpiration())
            {

                label1.Text = Calculate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
