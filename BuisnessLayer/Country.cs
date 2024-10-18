using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;

namespace BuisnessLayer
{
    public class Country
    {
        public int CountryID { get; set; }
        public String CountryName { get; set; }

        public Country()
        {
            this.CountryID = -1;
            this.CountryName = "";
        }

        private Country(int CountryID ,String CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static Country _Find(int CountryID){
            string CountryName = "";
            if(CountryDataAccess.GetCountryById(CountryID ,ref CountryName))
            {
                return new Country (CountryID,CountryName);
            }
            else
            {
                return null;
            }
        }

        public static Country _Find(string CountryName){
            int ID = -1;
            if(CountryDataAccess.GetCountryByName(CountryName ,ref ID))
            {
                return new Country (ID,CountryName);
            }
            else
            {
                return null;
            }
        }
        public static DataTable _GetAllCountries(){
            return CountryDataAccess.GetAllCountries();
        }
    }
}