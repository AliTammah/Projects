using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusnissLayer
{
    

    public class clsTests
    {
        public enum enMode { Add=0,Update=1};
        enMode Mode = enMode.Add;
        public int ID;
 public int AppID;
 public bool result;
 public string notes;
 public int UserID;
        
        public clsTests()
        {
            ID = 1;
            AppID = -1;
            result= true;
            notes = "";
            UserID = 1;
            Mode = enMode.Add;
        }
        private clsTests( int iD, int appID, bool result, string notes, int userID)
        {
            //Mode = mode;
            ID = iD;
            AppID = appID;
            this.result = result;
            this.notes = notes;
            UserID = userID;
            Mode = enMode.Update;
        }
        private bool _Add()
        {
            this.ID=clsDataTests.Add(this.AppID,this.result,this.notes,this.UserID);
            return this.ID != -1;
        }
        private bool _Update()
        {
            return clsDataTests.Update(this.ID,this.AppID,this.result,this.notes,this.UserID);
        }
        public static clsTests FindByID(int ID)
        {
            int AppID = -1;
            bool result = true;
            string notes = "";
            int UserID = -1;
            if (clsDataTests.GetInfoByID(ID, ref AppID, ref result, ref notes, ref UserID))
            {
                return new clsTests(ID, AppID, result, notes, UserID);

            }
            else
            {
                return null;
            }
        }
            public static clsTests FindByAppointmentID(int AppID)
        {
        int ID=-1;
        bool result=true;
        string notes="";
        int UserID=-1;
            if (clsDataTests.GetInfoByAppointmentID(AppID, ref ID, ref result, ref notes, ref UserID))
            {
                return new clsTests(ID, AppID, result, notes, UserID);

            }
            else
            {
                return null;
            }
    }
        public bool ISExist(int ID)
        {
            return clsDataTests.IsExistByAppoin(ID);
        }
        public bool Save()
        {
            switch (Mode)
            {

                case enMode.Add:
                    if (_Add())
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

    }
}
