using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace DataBusnissLayer
{
    public class clsLocalDrivingLicenseApplications
    {
        public int AppID;
        public int ClassID;
        public int ID;
     
        public clsLocalDrivingLicenseApplications()
        {
            this.ClassID = -1;
            this.AppID = -1;
            //this.AppInfoID = -1;
            //this.status = "";
            //this.ApplicantName = "";
            //this.PassedTestAcount = 0;
        }
        private clsLocalDrivingLicenseApplications(int ID,int appID, int classID)
        {
            this.AppID = appID;
            this.ClassID = classID;
            this.ID = ID;
        }
        private bool _Add()
        {
            this.ID = clsDataLocalDrivingLicenseApplication.Add(this.AppID, this.ClassID);
            return this.ID != -1;
        }
        public static clsLocalDrivingLicenseApplications Find(int LocalID)
        {
            int AppID = -1;
            int ClassID = -1;
            if (clsDataLocalDrivingLicenseApplication.GetInfoByID(LocalID, ref AppID, ref ClassID))
            {
                return new clsLocalDrivingLicenseApplications(LocalID,AppID, ClassID);
            }
            else
            {
                return null;
            }
            
        }
        public static clsLocalDrivingLicenseApplications FindByAppID(int AppID)
        {
            int LocalID = -1;
            int ClassID = -1;
            if (clsDataLocalDrivingLicenseApplication.GetInfoByAppID(AppID, ref LocalID, ref ClassID))
            {
                return new clsLocalDrivingLicenseApplications(LocalID,AppID, ClassID);
            }
            else
            {
                return null;
            }
            
        }
        public bool Save()
        {
            if (_Add())
            {
                return true;
            }
            return false;
        }
        public static bool Delete(int LocalID)
        {
            return clsDataLocalDrivingLicenseApplication.Delete(LocalID);
        }
    }
}
