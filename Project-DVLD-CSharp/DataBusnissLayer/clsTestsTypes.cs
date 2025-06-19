using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataBusnissLayer
{
    public class clsTestsTypes
    {
        public int TestID;
        //public string TestName;
        public string TestDescription;
        public string TestType;
        public decimal TestFees;
        public clsTestsTypes()
        {
            TestID = -1;
            TestDescription = "";
            TestType = "";
            TestFees = 0;
        }
        private clsTestsTypes(int testID, string testDescription, string testType, decimal testFees)
        {
            this.TestID = testID;
            this.TestDescription = testDescription;
            this.TestType = testType;
            this.TestFees = testFees;
        }
        private bool _Update()
        {
            return clsDataTestType.Update(this.TestID,this.TestType ,this.TestDescription,  this.TestFees);
        }
        public static DataTable GetAll()
        {
            return clsDataTestType.GetAll();
        }
        public static clsTestsTypes Find(int ID)
        {
            string TestType = "";
            string TestDescription = "";
            decimal TestFees = 0;
            if (clsDataTestType.GetInfo(ID, ref TestType, ref TestDescription, ref TestFees))
            {
                return new clsTestsTypes(ID, TestDescription, TestType, TestFees);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            if (_Update())
            {
                return true;
            }
            return false;
        }
    }
}
