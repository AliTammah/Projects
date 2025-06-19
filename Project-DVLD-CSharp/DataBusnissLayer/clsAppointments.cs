using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Threading.Tasks;
using System.Data;

namespace DataBusnissLayer
{
    public class clsAppointments
    {
        public enum enMode { Add=0,Update=1};
        enMode Mode = enMode.Add;
        public int ID;
        public int TesTypeID { get; set; }
        public int LocalID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int UserID { get; set; }
        public bool IsLocked { get; set; }
        public int ?RTAppID { get; set; }
        public clsAppointments()
        {
            ID = 0;
            UserID = -1;
            IsLocked = false;
            PaidFees = 0;
            AppointmentDate = DateTime.MinValue;
            LocalID = 0;
            TesTypeID = 0;
            RTAppID = null;
            Mode = enMode.Add;

        }
        private clsAppointments( int iD, int tesTypeID, int localID, DateTime appointmentDate, decimal paidFees, int userID, bool isLocked, int ?RTAppID)
        {
         //this. Mode = mode;
         this. ID = iD;
         this. TesTypeID = tesTypeID;
         this. LocalID = localID;
         this. AppointmentDate = appointmentDate;
         this. PaidFees = paidFees;
         this. UserID = userID;
         this. IsLocked = isLocked;
            this.RTAppID = RTAppID;
            Mode = enMode.Update;
        }
        private bool _Update()
        {
            return clsDataTestAppointments.Update(this.ID,this.TesTypeID,this.LocalID,this.AppointmentDate,
                this.PaidFees,this.UserID, this.IsLocked,this.RTAppID);
        }
        private bool _Add()
        {
            this.ID=clsDataTestAppointments.Add(this.ID,this.TesTypeID, this.LocalID,this.AppointmentDate,this.PaidFees, 
                this.UserID,this.IsLocked,this.RTAppID);
            return this.ID != -1;
        }
        public static DataTable GetAll()
        {
            return clsDataTestAppointments.GetAll();
        }
        public static DataTable GetAllByID(int ID)
        {
            return clsDataTestAppointments.GetAllByID(ID);
        }
        public static clsAppointments Find(int ID)
        {
            //int ID;
            int TesTypeID = -1;

            int LocalID = -1;

            DateTime AppointmentDate = DateTime.MinValue;
            decimal PaidFees = 1;
            int UserID = -1;
            int ?RTAppID = null;

            bool IsLocked = false;
            if (clsDataTestAppointments.GetInfoByID(ID, ref TesTypeID, ref LocalID,
                ref AppointmentDate, ref PaidFees, ref UserID, ref IsLocked,ref RTAppID))
            {
                return new clsAppointments(ID, TesTypeID, LocalID, AppointmentDate, PaidFees, UserID, IsLocked,RTAppID);
            }
            else
            {
                return null;
            }
        }
        public static clsAppointments FindByLocalID(int LocalID)
        {
            //int ID;
            int TesTypeID = -1;

            int ID = -1;

            DateTime AppointmentDate = DateTime.MinValue;
            decimal PaidFees = 1;
            int UserID = -1;
            int? RTAppID = null;

                
            bool IsLocked = false;
            if (clsDataTestAppointments.GetInfoByLocalID(LocalID, ref TesTypeID, ref ID, ref AppointmentDate, 
                ref PaidFees, ref UserID, ref IsLocked,ref RTAppID))
            {
                return new clsAppointments(ID, TesTypeID, LocalID, 
                    AppointmentDate, PaidFees, UserID, IsLocked,RTAppID);
            }
            else
            {
                return null;
            }
        }
        public bool IsExist(int ID)
        {
            return clsDataTestAppointments.IsExist(ID);
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
