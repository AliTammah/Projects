using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace DataBusnissLayer
{
    public class clsLicense
    {
        public enum enMode { Add, Update }

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public int PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int UserID { get; set; }

        public enMode Mode { get; set; }
        public string ClassName { get; set; }


        public clsLicense()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClass = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = string.Empty;
            PaidFees = 0;
            IsActive = true;
            IssueReason = -1;
            UserID = -1;
            Mode = enMode.Add;
        }

        private clsLicense(int licenseID, int applicationID, int driverID, int licenseClass,
            DateTime issueDate, DateTime expirationDate, string notes, int paidFees,
            bool isActive, int issueReason, int userID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            UserID = userID;
            Mode = enMode.Update;
        }

        private bool _Add()
        {
            LicenseID = clsDataLicense.Add(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate,
                Notes, PaidFees, IsActive, IssueReason, UserID);
            return LicenseID != -1;
        }

        private bool _Update()
        {
            return clsDataLicense.Update(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate,
                Notes, PaidFees, IsActive, IssueReason, UserID);
        }

        public static clsLicense Find(int licenseID)
        {
            int applicationID = -1, driverID = -1, paidFees = 0, issueReason = -1, userID = -1;
            int licenseClass = 0; string notes = string.Empty;
            DateTime issueDate = DateTime.MinValue, expirationDate = DateTime.MinValue;
            bool isActive = false;

            if (clsDataLicense.GetInfoByLicenseID(licenseID, ref applicationID, ref driverID, ref licenseClass,
                ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive,
                ref issueReason, ref userID))
            {
                return new clsLicense(licenseID, applicationID, driverID, licenseClass, issueDate,
                    expirationDate, notes, paidFees, isActive, issueReason, userID);
            }
            else
            {
                return null;
            }

        }
        public int GetLocalID()
        {
            int LocalID = clsLocalDrivingLicenseApplications.FindByAppID(this.ApplicationID).ID;
            return LocalID;
        }
        public static clsLicense FinByApplicationID(int ApplicationID)
        {
            int LicenseID = -1, driverID = -1, paidFees = 0, issueReason = -1, userID = -1;
            int licenseClass = 0; string notes = string.Empty;
            DateTime issueDate = DateTime.MinValue, expirationDate = DateTime.MinValue;
            bool isActive = false;

            if (clsDataLicense.GetInfoByApplicationID(ApplicationID, ref LicenseID, ref driverID, ref licenseClass,
                ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive,
                ref issueReason, ref userID))
            {
                return new clsLicense(LicenseID, ApplicationID, driverID, licenseClass, issueDate,
                    expirationDate, notes, paidFees, isActive, issueReason, userID);
            }
            else
            {
                return null;
            }
        }
        public static clsLicense LicenseInfo(int LocalID)
        { int AppID;

            AppID = clsLocalDrivingLicenseApplications.Find(LocalID).AppID;
            //int classID = clsLocalDrivingLicenseApplications.Find(LocalID).ClassID;

            return FinByApplicationID(AppID);
        }
        public static clspeople GetInfoPerson(int PersonID)
        {
            return clspeople.Find(PersonID);
        }
        public static string GetClassName(int LocalID)
        {
            int classID = clsLocalDrivingLicenseApplications.Find(LocalID).ClassID;
            return clsLicenseClasses.GetInfoByID(classID).ClassName;
        }
        public bool IsReleased()
        {
            if (clsDetainedLicenses.FindByLicenseID(this.LicenseID) != null)
                return clsDetainedLicenses.FindByLicenseID(this.LicenseID).IsReleased;
            return false;
        }
        public string GetIssueReason()
        {
            switch (this.IssueReason)
            {
                case 1:
                    return "First Time";
                case 2:
                    return "Renew";
                case 3:
                    return "Replacement for Lost";
                case 4:
                    return "Replacement for Damage";
                case 5:
                    return "Release Detained";
                case 6:
                    return "New international";
                case 7:
                    return "Retake Test";

            }
            return "";
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_Add())
                    {
                        Mode = enMode.Add;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static bool Delete(int licenseID)
        {
            return clsDataLicense.DeleteByLicenseID(licenseID);
        }

        //public static bool IsExist(int licenseID)
        //{
        //    return clsDataLicense.ISExistByID(licenseID);
        //}

        public static DataTable GetAll(int DriverID)
        {
            return clsDataLicense.GetAll(DriverID);
        }
        public static DataTable GetAllInternational()
        {
            return clsDataLicense.GetAllLicenseInternational();
        }

    
    public bool IsExpiration()
        {
            if (DateTime.Now > this.ExpirationDate)
            {
                return true;
            }
            return false;

        }
        //public static DataTable GetAllLicense(int DriverID)
        //{

        //}
        public bool ISActive()
        {
            return this.IsActive;
        }
        public static clsLicense CreateAppAndLicenseReplacementLostLicense(clsLicense license)
        {
            clsLicense ReplacementLicense = new clsLicense();
           
              license.IsActive = false;
                if (license.Save())
                {
                    //ReplacementLicense = license;
                    ReplacementLicense.IsActive = true;
                    ReplacementLicense.IssueReason =Convert.ToInt32( clsApplictionsTypeTitle.GetIdByName("ReplacementForLostDrivingLicense"));
                    ReplacementLicense.IssueDate = DateTime.Now;
                    ReplacementLicense.ExpirationDate = DateTime.Now.AddYears(Convert.ToInt16(clsLicenseClasses.GetInfoByID(license.LicenseClass).ValidityAge));
                    //ReplacementLicense.ApplicationID = ReplacementApp.ID;
                    ReplacementLicense.DriverID = license.DriverID;
                    ReplacementLicense.Notes = license.Notes;
                    ReplacementLicense.PaidFees = Convert.ToInt16(clsLicenseClasses.GetInfoByID(license.LicenseClass).ClassFees);
                    ReplacementLicense.UserID = clsUserSettings.UserID;
                    ReplacementLicense.LicenseClass = license.LicenseClass;
                }
            return ReplacementLicense;
        } 
        public static clsLicense CreateAppAndLicenseReplacementDamagedLicense(clsLicense license)
        {
            clsLicense ReplacementLicense = new clsLicense();
           
              license.IsActive = false;
                if (license.Save())
                {
                    //ReplacementLicense = license;
                    ReplacementLicense.IsActive = true;
                    ReplacementLicense.IssueReason =Convert.ToInt32( clsApplictionsTypeTitle.GetIdByName("ReplacementForDamagedDrivingLicense"));
                    ReplacementLicense.IssueDate = DateTime.Now;
                    ReplacementLicense.ExpirationDate = DateTime.Now.AddYears(Convert.ToInt16(clsLicenseClasses.GetInfoByID(license.LicenseClass).ValidityAge));
                    //ReplacementLicense.ApplicationID = ReplacementApp.ID;
                    ReplacementLicense.DriverID = license.DriverID;
                    ReplacementLicense.Notes = license.Notes;
                    ReplacementLicense.PaidFees = Convert.ToInt16(clsLicenseClasses.GetInfoByID(license.LicenseClass).ClassFees);
                    ReplacementLicense.UserID = clsUserSettings.UserID;
                    ReplacementLicense.LicenseClass = license.LicenseClass;
                }
            return ReplacementLicense;
        }

    } }
