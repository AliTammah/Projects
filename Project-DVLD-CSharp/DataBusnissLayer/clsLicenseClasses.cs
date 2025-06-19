using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer;

namespace DataBusnissLayer
{
    public class clsLicenseClasses
    {
       public  int ClassID;
        public string ClassName;
        public string Description;
        public int ValidityAge;
        public int MinimumAlloAge;
        public decimal ClassFees;
        public clsLicenseClasses() { 
        ClassID= 0;
            ClassName = "";
            Description = "";
            ValidityAge = 0;
            MinimumAlloAge = 0;
            ClassFees = 0;
        
        } 
      private clsLicenseClasses(int classID, string className, string description, int validityAge, int minimumAlloAge, decimal classFees)
        {
        this.  ClassID = classID;
        this.  ClassName = className;
        this.  Description = description;
        this.  ValidityAge = validityAge;
        this.  MinimumAlloAge = minimumAlloAge;
        this.  ClassFees = classFees;
        }
        public static DataTable GetAll()
        {
            return clsDataLicenseClass.GetAll();

        }
        public static clsLicenseClasses FindByName(string name)
        {
            string description = "";
            int classID = -1;
            byte validityLength = 0;
            byte allowAge = 0;
            decimal classFees = -1;
            if (clsDataLicenseClass.GetInfoByName(name, ref classID, ref description, ref allowAge,
                ref validityLength, ref classFees))
            {
                return new clsLicenseClasses(classID, name, description, validityLength, allowAge, classFees);
            }
            else
            {
                return null;
            }
        }
        public bool isExist(int ID)
        {
            return clsDataLicenseClass.IsExist(ID);
        }
        public static clsLicenseClasses GetInfoByID(int ID)
        {
            string description = "";
            string className = "";
            int validityLength = 0;
            int allowAge = 0;
            decimal classFees = 0;
            if (clsDataLicenseClass.GetInfoByID(ID, ref className, ref description, ref allowAge,
                ref validityLength, ref classFees))
            {
                return new clsLicenseClasses(ID, className, description, validityLength, allowAge, classFees);
            }
            else
            {
                return null;
            }

        }
    }
}
