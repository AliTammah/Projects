using DataBusnissLayer;
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
    public partial class ctrAddUpdateUser : UserControl
    {
        public ctrAddUpdateUser()
        {
            InitializeComponent();
        }
        //public static string PersonID = ctrInfoPerson1.;
        public string GetPersonID()
        {
            return ctrInfoPerson1.GetPersonID();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }
        public Dictionary<string ,string> FindBy=new Dictionary<string, string> {

            {"NationalNo","National No" },
            {"PersonID","PersonID" },
        
        };
     //public  static string ss=txtFind.Text;
        private void _FillComboBox()
        {
            cbFind.DataSource=new BindingSource(FindBy,null);
            cbFind.DisplayMember = "Value";
            cbFind.ValueMember = "Key";
             
        }
        private void ctrAddUpdateUser_Load(object sender, EventArgs e)
        {
            //cbFind.Items.Add("National No")
            _FillComboBox();
        }
        public bool IsPersonExist()
        {
            return clspeople.IsExist(Convert.ToInt32(txtFind.Text));
        }
        public bool IsPersonFinded = false;
        public void UserInfo(int UserID)
        {
            ctrInfoPerson1.PersonInfo(UserID);
            pbSearch.Enabled = false;
            pbAddUser.Enabled = false;
            txtFind.Enabled = false;
            cbFind.Enabled = false;
            cbFind.SelectedIndex=1;
            txtFind.Text=UserID.ToString();
            
            
        }
        public string GetTextFind()
        {
            return txtFind.Text;    
           
        }
        public string GetPersonNational()
        {
            return ctrInfoPerson1.GetPersonNational();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cbFind.SelectedValue.ToString() == "PersonID"&&txtFind.Text!="")
            {
                if (clspeople.IsExist(Convert.ToInt32(txtFind.Text)))
                {

                ctrInfoPerson1.PersonInfo(Convert.ToInt32(txtFind.Text));

                }
                else
                {
                    MessageBox.Show("This Person is Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (clspeople.IsExistByNational(txtFind.Text.ToString()))
                {
                    //if(clsUsers.is)
                    ctrInfoPerson1.PersonInfoByNational(txtFind.Text.ToString());
                }
                else
                {
                    MessageBox.Show("This Person is Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //ctrInfoPerson1.PersonInfoByNational(txtFind.Text);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.OnDataBackPerson += frmAddPerson;
                    
            frm.ShowDialog();
            
        }

        //private void Frm_OnDataBackPerson(object sender, int PersonID)
        //{
        //    throw new NotImplementedException();
        //}

        private void frmAddPerson(object sender, int PersonID)
        {
            //txtFind.Enabled = false;
            ctrInfoPerson1.PersonInfo(PersonID);
            txtFind.Text = PersonID.ToString();
            cbFind.SelectedIndex = 1;
            
        }
        public void FillPersonInfo(int personID)
        {
            ctrInfoPerson1.PersonInfo(personID);
            txtFind.Text = personID.ToString();
            cbFind.SelectedIndex = 1;
            groupBox1.Enabled = false;

        }

        private void ctrInfoPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
