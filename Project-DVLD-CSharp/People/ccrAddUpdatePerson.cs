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
using System.IO;
namespace project19
{
    public partial class ccrAddUpdatePerson : UserControl
    {
        //public enum enMode { Add=0, Update=1}
        //private enMode _Mode ;
        //int _PersonID ;
        public ccrAddUpdatePerson()
        {
            InitializeComponent();
            //_PersonID = PersonID;
            //if (_PersonID== -1)
            //{
            //    _Mode = enMode.Add;

            //}
            //else
            //{
            //    _Mode = enMode.Update;
            //}
        }
        clspeople _person=new clspeople();
        public int CountryID { get; set; }

        public void AddCountriesName(string country)
        {
            cbCountry.Items.Add(country);
            cbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public int GetCountryID()
        {
            return cbCountry.SelectedIndex;
        }
         clspeople _currentPerson=new clspeople();
        public clspeople GetUpdatedPerson()
        {
            if (cbCountry.Text == "")
            {
                //MessageBox.Show("Write  Person Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            int countryID = clsCountries.Find(cbCountry.Text).CountryID;

            _currentPerson.CountryID = countryID;
            _currentPerson.FirstName = txtFirst.Text;
            _currentPerson.SecondName = txtSecond.Text;
            _currentPerson.ThirdName = txtThird.Text;
            _currentPerson.LastName = txtLast.Text;
            _currentPerson.Phone = txtPhone.Text;
            _currentPerson.Email = txtEmail.Text;
            _currentPerson.Address = txtAddress.Text;
            _currentPerson.DateOfBirth = Convert.ToDateTime(dtDate.Text);
            _currentPerson.National = txtNational.Text;
            _currentPerson.Gender = rbMale.Checked ? (byte)1 : (byte)0;

            _currentPerson.ImagePath = pbImage.ImageLocation ?? " ";

            //_currentPerson.Mode = (_currentPerson.ID == -1) ? clspeople.enMode.Add : clspeople.enMode.Update;

            return _currentPerson;
        }

        private void ccrAddUpdatePerson_Load(object sender, EventArgs e)
        {

        }

        private void llbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbImage.Load(selectedFilePath);
                //pbImage.Image = Image.FromFile(ofd.FileName);
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public bool SaveImagePeopleInFolder(clspeople person,string oldImagePath)
        {
            string imagesFolder = @"C:\Users\LENOVO\source\repos\DVLD_PeopleImages";

            try
            {
                if (pbImage.Image == null)
                    return false;

                // تأكد من وجود المجلد
                Directory.CreateDirectory(imagesFolder);

                // حذف الصورة القديمة إن كانت ضمن نفس المجلد
                if (!string.IsNullOrWhiteSpace(person.ImagePath) && File.Exists(oldImagePath))
                {
                    string oldImageDir = Path.GetFullPath(Path.GetDirectoryName(oldImagePath));
                    string targetDir = Path.GetFullPath(imagesFolder);

                    if (string.Equals(oldImageDir, targetDir, StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            File.Delete(oldImagePath);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("خطأ أثناء حذف الصورة القديمة: " + ex.Message);
                        }
                    }
                }

                // توليد اسم جديد وحفظ الصورة
                string newFileName = Guid.NewGuid().ToString() + ".jpg";
                string fullDestinationPath = Path.Combine(imagesFolder, newFileName);

                pbImage.Image.Save(fullDestinationPath, System.Drawing.Imaging.ImageFormat.Jpeg);

                person.ImagePath = fullDestinationPath;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("خطأ أثناء حفظ الصورة: " + ex.Message);
                return false;
            }
        }


        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbImage.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\Female 512.png");
            //pbImage.ImageLocation = "F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\Female512.png";
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbImage.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\Male 512.png");

        }
        public void LoadData(clspeople person) 
        {
           
            _currentPerson = person; // حفظ نسخة محلية للكائن

            txtAddress.Text = person.Address;
            txtFirst.Text = person.FirstName;
            txtLast.Text = person.LastName;
            txtSecond.Text = person.SecondName;
            txtThird.Text = person.ThirdName;
            txtEmail.Text = person.Email;
            txtNational.Text = person.National;
            txtPhone.Text = person.Phone;
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountries.FindByID(person.CountryID).CountryName);

            if (person.Gender == 0)
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }

            if (person.ImagePath != "")
            {
                pbImage.Load(person.ImagePath);
            }
            llRemove.Visible = (person.ImagePath != " ");
            dtDate.Value = person.DateOfBirth;
        }

        private void txtNational_TextChanged(object sender, EventArgs e)
       {
            if (clspeople.IsExistByNational(txtNational.Text))
            {
                erpNational.SetError(txtNational, "This person already exists");
            }
            else
            {
                erpNational.SetError(txtNational, "");
            }
        }

        private void txtNational_Validating(object sender, CancelEventArgs e)
        {

        }
        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age)) age--; // تصحيح العمر لو تاريخ الميلاد بعد اليوم في نفس السنة
            return age;
        }

        private void dtDate_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtThird_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtThird.Text))
            {
                errorProvider2.SetError(txtThird, "This Required ");
                e.Cancel = true;
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
