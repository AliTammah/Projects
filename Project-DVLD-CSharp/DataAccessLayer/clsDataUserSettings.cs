using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer
{
    internal class clsDataUserSettings
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public clsDataUserSettings()
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
