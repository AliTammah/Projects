using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusnissLayer
{
    public class clsDrivers
    {
        public enum enMode { Add, Update }

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public enMode Mode { get; set; }

        public clsDrivers()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
            Mode = enMode.Add;
        }

        private clsDrivers(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
            Mode = enMode.Update;
        }

        private bool _Add()
        {
            DriverID = clsDataDrivers.Add(PersonID, CreatedByUserID, CreatedDate);
            return DriverID != -1;
        }

        private bool _Update()
        {
            return clsDataDrivers.Update(DriverID, PersonID, CreatedByUserID, CreatedDate);
        }

        public static clsDrivers Find(int driverID)
        {
            int personID = -1;
            int createdByUserID = -1;
            DateTime createdDate = DateTime.MinValue;

            if (clsDataDrivers.GetInfoByDriverID(driverID, ref personID, ref createdByUserID, ref createdDate))
            {
                return new clsDrivers(driverID, personID, createdByUserID, createdDate);
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

        public static bool Delete(int driverID)
        {
            return clsDataDrivers.DeleteByDriverID(driverID);
        }

        public static bool IsExist(int driverID)
        {
            return clsDataDrivers.ISExistByID(driverID);
        }

        public static DataTable GetAll()
        {
            return clsDataDrivers.GetAll();
        }
        public static DataTable GetAllFromDriversView()
        {
            return clsDataDrivers.GetAllFromDriversView();
        }
    }
}
