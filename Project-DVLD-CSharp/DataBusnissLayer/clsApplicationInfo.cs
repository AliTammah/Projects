using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataBusnissLayer
{
    public class clsApplicationInfo
    {
        public int ID;
        public string ApplicantName;
        public string status;
        public int PassedTestAcount;
        public clsApplicationInfo() {

            ID = 0;
            ApplicantName = "";
            status = "";
            PassedTestAcount = 0;
        }
        private clsApplicationInfo(int iD, string applicantName, string status, int passedTestAcount)
        {
            this.ID = iD;
            this.ApplicantName = applicantName;
            this.status = status;
            this.PassedTestAcount = passedTestAcount;
        }

        public static clsApplicationInfo Find(int ID)
        {
            //int AppInfoID=-;
            string ApplicantName = "";
            string status = "";
            int PassedTestAcount = -1;
            if (clsDataApplicationInfo.GetInfoApplicationBasic(ID, ref ApplicantName, ref PassedTestAcount, ref status))
            {
                return new clsApplicationInfo(ID, ApplicantName, status, PassedTestAcount);
            }
            else { return null; }

        } 
    }
}
