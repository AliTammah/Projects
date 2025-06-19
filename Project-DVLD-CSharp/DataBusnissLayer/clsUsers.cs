using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataBusnissLayer
{
    public class clsUsers
    {
        public enum enMode { Add=0,Update=1};
        enMode Mode = enMode.Add;
        public int UserID {  get; set; }
        public int PersonID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public clsUsers()
        { 
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = " ";
            IsActive = false;
            Mode = enMode.Add;
        }
        private clsUsers( int userID, int personID, string userName, string password, bool isActive)
        {
            //Mode = mode;
          this. UserID = userID;
          this. PersonID = personID;
          this. UserName = userName;
          this. Password = password;
          this. IsActive = isActive;
            Mode = enMode.Update;
        }

        private bool _AddUser()
        {
            this.UserID=clsDataUsers.AddUser(this.PersonID, this.UserName,this.Password,this.IsActive);
            return (this.UserID!=-1);
        }
        private bool _UpdateUser()
        {
            return clsDataUsers.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password,this.IsActive);
        }
        public static DataTable GetAll()
        {
            return clsDataUsers.GetAllUsers();
        }
        public static bool IsExist(int UserID)
        {
            return clsDataUsers.IsExist(UserID);
        }
        public static bool IsExistByPersonID(int PersonID)
        {
            return clsDataUsers.IsExistByPersonID(PersonID);
        }

        public static bool DeleteUser(int UserID)
        {
            return clsDataUsers.DeleteUser(UserID);
        }
        public static clsUsers Find(int UserID)
        {
            string UserName = "", Password = "";
            int personID = -1;
            bool isActive = false;
            if (clsDataUsers.GetInfoByID(UserID, ref personID, ref UserName, ref Password, ref isActive))
            {
                return new clsUsers(UserID, personID, UserName, Password, isActive);
            }
            else
            {
                return null;
            }
        }
        public static clsUsers FindByUserName(string userName)
        {
            string  Password = "";
            int UserID=-1;
            int personID = -1;
            bool isActive = false;
            if (clsDataUsers.GetInfoByUserName(userName, ref personID,ref UserID, ref Password, ref isActive))
            {
                return new clsUsers(UserID, personID, userName, Password, isActive);
            }
            else
            {
                return null;
            }
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                   if(_AddUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false;
                    }
                   case enMode.Update:
                   return  _UpdateUser();
            }
              return false;
        }
        public static bool IsExistByUserName(string userName)
        {
            return clsDataUsers.IsExistByUserName(userName);
        }
    }
}
