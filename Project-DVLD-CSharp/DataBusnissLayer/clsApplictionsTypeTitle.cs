using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataBusnissLayer
{
    public class clsApplictionsTypeTitle
    {
        //public   enum enMode { A}
        public enum ApplicationType
        {
            NewLocalDrivingLicenseService = 1,
            RenewDrivingLicenseService = 2,
            ReplacementForLostDrivingLicense = 3,
            ReplacementForDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicense = 5,
            NewInternationalLicense = 6,
            RetakeTest = 7
        }


        public int AppID;
      public  decimal fees;
      public  string AppName;
        public clsApplictionsTypeTitle()
        {
            AppID = 0;
            AppName = "";
            fees= 0;
        }
      private clsApplictionsTypeTitle(int appID, decimal fees,string AppName)
        {
            this.AppID = appID;
            this.fees
                = fees;
            this.AppName = AppName;
        }
        private bool _UpdateApplictions()
        {
            return clsDataApplicationsType.Update(this.AppID,this.AppName,this.fees);
        }
        public static DataTable GetAll()
        {
            return clsDataApplicationsType.GetAll();
        }
        public static clsApplictionsTypeTitle Find(int appID) 
        {
            string AppName = "";
            decimal fees = 0;
            if (clsDataApplicationsType.GetInfoByID(appID, ref AppName, ref fees))
            {
                return new clsApplictionsTypeTitle(appID,  fees,AppName);
            }
            else
            {

                return null;
            }
        
        } 
        public static clsApplictionsTypeTitle FindByName(string className) 
        {
            int ID =-1;
            decimal fees = 0;
            if (clsDataApplicationsType.GetInfoByName(className, ref ID, ref fees))
            {
                return new clsApplictionsTypeTitle(ID,  fees,className);
            }
            else
            {

                return null;
            }
        
        }
        public bool Save()
        {
            if (_UpdateApplictions())
                return true;
            else
            {
                return false;
            }
        }
         // من رقم إلى اسم
            public static string GetNameById(int id)
            {
                if (Enum.IsDefined(typeof(ApplicationType), id))
                    return Enum.GetName(typeof(ApplicationType), id);
                return null;
            }

        // من اسم إلى رقم
        public static int? GetIdByName(string name)
        {
            if (Enum.TryParse<ApplicationType>(name, true, out var result))
                return (int)result;

            return null;
        }
        private static readonly Dictionary<ApplicationType, decimal> feesApp = new Dictionary<ApplicationType, decimal>
    {
        { ApplicationType.NewLocalDrivingLicenseService, 15.00m },
        { ApplicationType.RenewDrivingLicenseService, 7.00m },
        { ApplicationType.ReplacementForLostDrivingLicense, 10.00m },
        { ApplicationType.ReplacementForDamagedDrivingLicense, 5.00m },
        { ApplicationType.ReleaseDetainedDrivingLicense, 15.00m },
        { ApplicationType.NewInternationalLicense, 51.00m },
        { ApplicationType.RetakeTest, 5.00m }
    };

        //public static decimal? GetFee(ApplicationType type)
        //{
        //    return feesApp.TryGetValue(type, out var fee) ? fee : null;
        //}

        //public static decimal? GetFeeById(int id)
        //{
        //    if (Enum.IsDefined(typeof(ApplicationType), id))
        //    {
        //        var type = (ApplicationType)id;
        //        return GetFee(type);
        //    }
        //    return null;
        //}


    }
}
