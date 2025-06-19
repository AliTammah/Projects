using DataAccessLayer;
using System;
using System.Data;
namespace DataBusnissLayer
{
    public class clspeople
    {
        public enum enMode { Add = 0, Update = 1 };
        public enMode Mode=enMode.Add ;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
        public byte Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImagePath { get; set; }
        public string National { get; set; }
        public string FullName { get; set; }
        public clspeople()
        {
            ID = -1;
            FirstName = " ";
            SecondName = " ";
            ThirdName = " ";
            LastName = " ";
            Phone = " ";
            Email = " ";
            Address = " ";
            CountryID = 0;
            Gender = 0;
            DateOfBirth = DateTime.Now;
            ImagePath = " ";
            National = " ";
            Mode = enMode.Add;
        }
        private clspeople(int ID, string FirstName, string SecondName, string ThirdName, string LastName,
           string Phone, string Email, byte Gender, DateTime dateOfBirth, string ImagePath, int CountryID, string Address,
           string National)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.National = National;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.Gender = Gender;
            this.DateOfBirth = dateOfBirth;
            this.ImagePath = ImagePath;
            this.CountryID = CountryID;
            this.Address = Address;
            Mode = enMode.Update;
            this.FullName = FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
                ;

        }
        private bool _AddNewPersone()
        {
            this.ID = clsDataPeople.AddPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName,

                   this.Phone, this.Gender, this.National, this.Email, this.CountryID, this.Address, this.DateOfBirth, this.ImagePath);
            return (this.ID != -1);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewPersone())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _Update();

            }
            return false;

        }
        private bool _Update()
        {
            return clsDataPeople.UpdatePeople(this.ID, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.Phone, this.Gender, this.National, this.Email, this.CountryID, this.Address, this.DateOfBirth, this.ImagePath);
        }
        public static clspeople Find(int ID)
        {
            //int ID = -1;
            string FirstName = " ";
            string SecondName = " ";
            string ThirdName = " ";
            string LastName = " ";
            string Phone = " ";
            string Email = " ";
            string Address = " ";
            int CountryID = -1;
            byte Gender = 0;
            DateTime DateOfBirth = DateTime.Now;
            string ImagePath = " ";
            string National = " ";
            if (clsDataPeople.GetInfoByID(ID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Phone, ref Gender, ref National, ref Email, ref CountryID, ref Address, ref DateOfBirth, ref ImagePath))
            {
                return new clspeople(ID, FirstName, SecondName, ThirdName, LastName, Phone
                    , Email, Gender, DateOfBirth, ImagePath, CountryID,
                    Address, National);
            }
            else
            {
                return null;
            }

        }
        public static DataTable GetAllPeople()
        {
            return clsDataPeople.GetAllPeople();
        }
        public static bool IsExist(int PersonID)
        {
            return clsDataPeople.IsExist(PersonID);
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsDataPeople.DeletePeople(PersonID);
        }
        public static bool IsExistByNational(string Namtional)
        {
            return clsDataPeople.IsExistByNational(Namtional);
        } 
        public static clspeople GetInfoByNational(string Namtional)
        {
            int PersonID = -1;
            string FirstName = " ";
            string SecondName = " ";
            string ThirdName = " ";
            string LastName = " ";
            string Phone = " ";
            string Email = " ";
            string Address = " ";
            int CountryID = -1;
            byte Gender = 0;
            DateTime DateOfBirth = DateTime.Now;
            string ImagePath = " ";
            string National = " ";
            if (clsDataPeople.GetInfoByNational(Namtional, ref FirstName,ref  PersonID, ref SecondName, ref ThirdName, ref LastName,
                ref Phone, ref Gender, ref Email, ref CountryID, ref Address, ref DateOfBirth, ref ImagePath))
            {
                return new clspeople(PersonID, FirstName, SecondName, ThirdName, LastName, Phone
                    , Email, Gender, DateOfBirth, ImagePath, CountryID,
                    Address, National);
            }
            else
            {
                return null;
            }

        }
        //public string FullName()
        //{

        //}

    }
}
