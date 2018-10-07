using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.BLLayer
{
    public class CountryBLL
    {
        public static DataTable GetAll()
        {            
            return CountryDAL.GetAll();
        }

        public static DataTable GetById(int Id)
        {
            return CountryDAL.GetById(Id);
        }

        public static bool CheckNameInserted(string countryName)
        {
            return CountryDAL.CheckNameInserted( countryName);
        }

        public static int InsertNewCountry(string countryName)
        {
            return CountryDAL.InsertNewCountry( countryName);
        }

    }
}