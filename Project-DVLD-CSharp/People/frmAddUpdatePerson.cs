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
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackPerson(object sender, int PersonID);
        public event DataBackPerson OnDataBackPerson;
        public enum enMode { Add = 0, Update = 1 }
        private enMode _Mode;
        int _PersonID;
        clspeople _Person;
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            if (_PersonID == -1)
            {
                _Mode = enMode.Add;

            }
            else
            {
                _Mode = enMode.Update;
            }
        }
       clsCountries _countries=new clsCountries();

        private void _LoadData()
        {
            if (_Mode == enMode.Add)
            {
                lbAddPerson.Text = "Add New Person";
                _Person=new clspeople();
                return;

            }
            _Person=clspeople.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                this.Close();
                return;
            }
            else
            {
                lbAddPerson.Text = "Update Person";
                lbPersonIDAdded.Text=_PersonID.ToString();
                
                ccrAddUpdatePerson1.LoadData(_Person);
            }
            }
        private void Form1_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void ccrAddUpdatePerson1_Load(object sender, EventArgs e)
        {
            
        }

        private void ccrAddUpdatePerson1_Load_1(object sender, EventArgs e)
        {
            DataTable dataTable = _countries.GetAllCountries();
            foreach (DataRow row in dataTable.Rows)
            {
                ccrAddUpdatePerson1.AddCountriesName(row["CountryName"].ToString());
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (lbPersonIDAdded.Text != "")
            {
                int PersonId = int.Parse(lbPersonIDAdded.Text);
                OnDataBackPerson?.Invoke(this, PersonId);
                this.Close();
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _Person = ccrAddUpdatePerson1.GetUpdatedPerson();
           if(_Person == null)
            {
                MessageBox.Show("Write all Data Person ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string oldPathImage = _Person.ImagePath;
           

            if (ccrAddUpdatePerson1.SaveImagePeopleInFolder(_Person,oldPathImage))
            {
                if (_Person.Save())
                {
                    MessageBox.Show("Saved Successfully");
                    _PersonID = _Person.ID;
                    lbPersonIDAdded.Text = _PersonID.ToString();
                    

                }
                else
                {
                    MessageBox.Show("Failed to save person data.");
                }
            }
            else
            {
                MessageBox.Show("Failed to save image.");
            }
            if (_Person.National == "")
            {
                MessageBox.Show("Write  Person Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //}
            //ccrAddUpdatePerson1.SaveImagePeopleInFolder();
            _Mode =enMode.Update;
            //lbPersonIDAdded.Text = _PersonID.ToString();
        }
        
        private void lbPersonID_Click(object sender, EventArgs e)
        {

        }
    }
}
