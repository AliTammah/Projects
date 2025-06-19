using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataBusnissLayer
{
    public  class clsApplications
    {
        public enum enMode { Add=0,Update=1};
        enMode Mode = enMode.Add;
     public int ID;
     public int AppPersonID;
     public DateTime AppDate;
     public int AppTypeID;
     public int AppStatus;
     public DateTime LastStatusDate;
     public decimal PaidFees;
     public int UserID;
        public clsApplications()
        {
            ID = -1;
            AppPersonID = -1;
            AppDate = DateTime.Now;
            AppTypeID = -1;
            AppStatus = -1;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            UserID = -1;
            Mode = enMode.Add;
        }
        private clsApplications( int iD, int appPersonID, DateTime appDate, int appTypeID, int appStatus, DateTime lastStatusDate, decimal paidFees, int userID)
        {
         //this. Mode = mode;
         this. ID = iD;
         this. AppPersonID = appPersonID;
         this. AppDate = appDate;
         this. AppTypeID = appTypeID;
         this. AppStatus = appStatus;
         this. LastStatusDate = lastStatusDate;
         this. PaidFees = paidFees;
         this. UserID = userID;
            Mode = enMode.Update;
        }
        private bool _AddApp()
        {
            this.ID=clsDataApplications.Add(this.AppPersonID, this.AppDate,this.AppTypeID,this.AppStatus,this.LastStatusDate,
                this.PaidFees,this.UserID);
            return this.ID != -1;
        }
        private bool _Update()
        {
            return clsDataApplications.Update(this.ID, this.AppPersonID, this.AppDate, this.AppTypeID, this.AppStatus, this.LastStatusDate,
                this.PaidFees, this.UserID);
        }
        public static DataTable GetAll()
        {
            return clsDataApplications.GetAll();
        }
        public static clsApplications Find(int appID)
        {
         //int  ID = -1;
         int  AppPersonID = -1;
         DateTime  AppDate = DateTime.MinValue;
         int  AppTypeID = -1;
         int  AppStatus = -1;
         DateTime  LastStatusDate = DateTime.MinValue;
            decimal PaidFees = 0;
         int  UserID = -1;
            if(clsDataApplications.GetInfoByID(appID,ref AppPersonID,ref AppDate,ref AppTypeID,
                ref AppStatus,ref LastStatusDate,ref PaidFees,ref UserID))
            {
                return new clsApplications(appID,AppPersonID,AppDate,AppTypeID,AppStatus,LastStatusDate,PaidFees,UserID);
            }
            else
            {
                return null;
            }
        }

        public bool IsExist(int appID)
        {
            return clsDataApplications.ISExistByID(appID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddApp())
                    {
                        Mode = enMode.Add;
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
        public static DataTable GetAllLocalDriving()
        {
            return clsDataApplications.GetAllLocalDriving();
        }
        public static bool UpdateStatus(int appID,int status)
        {
            return clsDataApplications.UpdateStatus(appID,status);
        }
        public static bool Delete(int ID)
        {
            return clsDataApplications.Delete(ID);
        }
        public static clsApplications CreateReplacementLostLicenseApp(clsApplications applications)
        {

            clsApplications ReplacementApp = new clsApplications();


            ReplacementApp.AppDate = DateTime.Now;
            ReplacementApp.AppPersonID = applications.AppPersonID;
            ReplacementApp.AppTypeID = Convert.ToInt32(clsApplictionsTypeTitle.GetIdByName("ReplacementForLostDrivingLicense"));
            ReplacementApp.LastStatusDate = DateTime.Now;
            ReplacementApp.UserID = clsUserSettings.UserID;
            ReplacementApp.AppStatus = 3;
            ReplacementApp.PaidFees = clsApplictionsTypeTitle.Find(Convert.ToInt32(clsApplictionsTypeTitle.GetIdByName("ReplacementForLostDrivingLicense"))).fees;
            ReplacementApp.Save();
           return ReplacementApp;
        }   
        public static clsApplications CreateReplacementDamagedLicenseApp(clsApplications applications)
        {

            clsApplications ReplacementApp = new clsApplications();


            ReplacementApp.AppDate = DateTime.Now;
            ReplacementApp.AppPersonID = applications.AppPersonID;
            ReplacementApp.AppTypeID = Convert.ToInt32(clsApplictionsTypeTitle.GetIdByName("ReplacementForDamagedDrivingLicense"));
            ReplacementApp.LastStatusDate = DateTime.Now;
            ReplacementApp.UserID = clsUserSettings.UserID;
            ReplacementApp.AppStatus = 3;
            ReplacementApp.PaidFees = clsApplictionsTypeTitle.Find(Convert.ToInt32(clsApplictionsTypeTitle.GetIdByName("ReplacementForDamagedDrivingLicense"))).fees;
            ReplacementApp.Save();
return ReplacementApp;
        }
    }
}
