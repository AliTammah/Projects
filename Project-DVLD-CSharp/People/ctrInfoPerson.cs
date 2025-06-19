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
    public partial class ctrInfoPerson : UserControl
    {

        public ctrInfoPerson()
        {
            InitializeComponent();
        }
        public void PersonInfo(int PersonID)
        {
        clspeople _person = new clspeople();
            //DataTable dt = new DataTable();
            _person = clspeople.Find(PersonID);
            lbPerson.Text = PersonID.ToString();
            lbNamee.Text=_person.FirstName +" "+_person.SecondName+" "+_person.ThirdName+" "+_person.LastName;
            lbNationalNo.Text=_person.National;
            lbPhonee.Text=_person.Phone;
            lbAddres.Text = _person.Address;
           lbGmail.Text=_person.Email;
            lbCountry.Text=clsCountries.FindByID(_person.CountryID).CountryName;
            if (_person.Gender == 1)
            {

                lbGendor.Text = "Male";
            }
            else
            {
                lbGendor.Text = "Female";
                pbMaleORFemale.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\Female 512.png");
            }
            lbDatOFBirth.Text=_person.DateOfBirth.ToString("yyyy-MM-dd");
            if (_person.ImagePath != "")
            {
                pbImage.Load(_person.ImagePath);
            }
            else
            {
                pbImage.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\Female 512.png");
            }

        } 
        public void PersonInfoByNational(string  National)
        {
        clspeople _person = new clspeople();
            //DataTable dt = new DataTable();
            _person = clspeople.GetInfoByNational(National);
            lbPerson.Text = _person.ID.ToString();
            lbNamee.Text=_person.FirstName +" "+_person.SecondName+" "+_person.ThirdName+" "+_person.LastName;
            lbNationalNo.Text=National;
            lbPhonee.Text=_person.Phone;
            lbAddres.Text = _person.Address;
           lbGmail.Text=_person.Email;
            lbCountry.Text=clsCountries.FindByID(_person.CountryID).CountryName;
            if (_person.Gender == 1)
            {

                lbGendor.Text = "Male";
            }
            else
            {
                lbGendor.Text = "Female";
                pbMaleORFemale.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\Female 512.png");
            }
            lbDatOFBirth.Text=_person.DateOfBirth.ToString("yyyy-MM-dd");
            if (_person.ImagePath != "")
            {
                pbImage.Load(_person.ImagePath);
            }
            else
            {
                pbImage.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\Female 512.png");
            }

        }
        private void ctrInfoPerson_Load(object sender, EventArgs e)
        {

        }
        public string GetPersonID()
        {
            return lbPerson.Text;
        }
        public string GetPersonNational()
        {
            return lbNationalNo.Text;
        }
        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm=new frmAddUpdatePerson(Convert.ToInt32( lbPerson.Text));
            frm.ShowDialog();
        }
    }
}
