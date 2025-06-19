using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataBusnissLayer
{
    public class clsCountries
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountries()
        {
            CountryID = -1;
            CountryName = " ";
        }
        private clsCountries(int countryID, string countryName)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
        }
        public  DataTable GetAllCountries()
        {
            return clsDataCountries.GetAllCountries();
        }
        public static clsCountries Find(string countryName)
        {
            //string countryName = " ";
            int countryID = -1;

            if (clsDataCountries.GetCountryByName(countryName, ref countryID))
            {
                return new clsCountries(countryID, countryName);
            }
            else
            {
                return null;
            }


        }  public static clsCountries FindByID(int CountryID)
        {
            string countryName = " ";
            //int countryID = -1;

            if (clsDataCountries.GetCountryByID(CountryID, ref countryName))
            {
                return new clsCountries(CountryID, countryName);
            }
            else
            {
                return null;
            }


        }
        public bool IsExist(string countryName)
        {
            return clsDataCountries.IsExist(countryName);
        }

    }
}
