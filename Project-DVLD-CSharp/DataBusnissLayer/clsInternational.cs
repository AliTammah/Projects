using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusnissLayer
{
    public class clsInternational
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        //public clsInternational() { }
        public clsInternational()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddYears(1);
            this.IsActive = true;
            this.CreatedByUserID = -1;
        }

        private clsInternational(int internationalLicenseID, int applicationID, int driverID,
            int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            this.InternationalLicenseID = internationalLicenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.IsActive = isActive;
            this.CreatedByUserID = createdByUserID;
        }

        private bool _Add()
        {
            this.InternationalLicenseID = clsDataInternationalLicense.Add(
                this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return this.InternationalLicenseID != -1;
        }

        public bool Save()
        {
            if (this.InternationalLicenseID == -1)
            {
                return _Add();
            }
            else
            {
                return false;
            }
        }
        public static clsInternational Find(int ID)
        {
            clsInternational license = null;

            int ApplicationID = 0, DriverID = 0, IssuedUsingLocalLicenseID = 0, CreatedByUserID = 0;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            bool IsActive = false;

            if (clsDataInternationalLicense.GetInfoByID(ID, ref ApplicationID, ref DriverID,
                ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate,
                ref IsActive, ref CreatedByUserID))
            {
                license = new clsInternational
                {
                    InternationalLicenseID = ID,
                    ApplicationID = ApplicationID,
                    DriverID = DriverID,
                    IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID,
                    IssueDate = IssueDate,
                    ExpirationDate = ExpirationDate,
                    IsActive = IsActive,
                    CreatedByUserID = CreatedByUserID
                };
            }
            else
            {
                return null;
            }

            return license;
        }
        public static DataTable GetAll()
        {
            return clsDataInternationalLicense.GetAll();
        }
        public bool Delete(int IntID)
        {
            return clsDataInternationalLicense.DeleteByID(IntID);
        }
        public static bool ISExistByLocalID(int LocalID)
        {
           return clsDataInternationalLicense.IsExist(LocalID);
        }
        public static DataTable GetAllByInternationalAppID(int AppID)
        {
            return clsDataInternationalLicense.GetAllByInternationalAppID(AppID);
        }
    }
}
