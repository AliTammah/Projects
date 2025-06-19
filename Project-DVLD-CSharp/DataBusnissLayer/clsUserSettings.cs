using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusnissLayer
{
    public class clsUserSettings
    {
        public static int UserID { get; set; }
        public static int  PersonID { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static bool IsActive { get; set; }
        public clsUserSettings()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = " ";
            IsActive = false;
            //Mode = enMode.Add;
        }
    }
}
