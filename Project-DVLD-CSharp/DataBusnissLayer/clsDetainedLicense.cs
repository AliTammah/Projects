using DataAccessLayer;
using System;
using System.Data;

namespace DataBusnissLayer
{
    public class clsDetainedLicenses
    {
        public enum enMode { Add = 0, Update = 1 }
        private enMode Mode = enMode.Add;

        public int ID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        public clsDetainedLicenses()
        {
            ID = 0;
            LicenseID = 0;
            DetainDate = DateTime.MinValue;
            FineFees = 0;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = null;
            ReleasedByUserID = null;
            ReleaseApplicationID = null;
            Mode = enMode.Add;
        }

        private clsDetainedLicenses(int id, int licenseID, DateTime detainDate, decimal fineFees,
            int createdByUserID, bool isReleased, DateTime? releaseDate,
            int? releasedByUserID, int? releaseApplicationID)
        {
            ID = id;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
            Mode = enMode.Update;
        }

        private bool _Add()
        {
            ID = clsDataDetainedLicenses.Add(LicenseID, DetainDate, FineFees, CreatedByUserID,
                IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            return ID != -1;
        }

        private bool _Update()
        {
            return clsDataDetainedLicenses.Update(ID, LicenseID, DetainDate, FineFees,
                CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
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
                    return false;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static DataTable GetAll()
        {
            return clsDataDetainedLicenses.GetAll();
        }

        //public static DataTable GetAllByID(int ID)
        //{
        //    return clsDataDetainedLicenses.GetAllByID(ID);
        //}

        public static clsDetainedLicenses Find(int ID)
        {
            int licenseID = 0;
            DateTime detainDate = DateTime.MinValue;
            decimal fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime? releaseDate = null;
            int? releasedByUserID = null;
            int? releaseApplicationID = null;

            if (clsDataDetainedLicenses.GetInfoByID(ID, ref licenseID, ref detainDate, ref fineFees,
                ref createdByUserID, ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainedLicenses(ID, licenseID, detainDate, fineFees,
                    createdByUserID, isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }

            return null;
        }

        public static clsDetainedLicenses FindByLicenseID(int licenseID)
        {
            int detainID = 0;
            DateTime detainDate = DateTime.MinValue;
            decimal fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime? releaseDate = null;
            int? releasedByUserID = null;
            int? releaseApplicationID = null;

            if (clsDataDetainedLicenses.GetInfoByLicenseID(licenseID, ref detainID, ref detainDate, ref fineFees,
                ref createdByUserID, ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainedLicenses(detainID, licenseID, detainDate, fineFees,
                    createdByUserID, isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }

            return null;
        }

        //public static bool IsExist(int ID)
        //{
        //    return clsDataDetainedLicenses.(ID);
        //}
    }
}
