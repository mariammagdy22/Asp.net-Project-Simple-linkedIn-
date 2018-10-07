using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class CountryDAL
    {
        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery("select * from Country");
            return dt;
        }

        public static DataTable GetById(int Id)
        {

            DataTable dt = DBL.ExecuteQuery("select * from Country where Country.CountryId = " + Id );
            return dt;
        }

        public static bool CheckNameInserted(string countryName)
        {
            DataTable dt = DBL.ExecuteQuery($"select count(Name) as NCount from Country where Name = '{countryName}'");
            return Convert.ToInt32(dt.Rows[0]["NCount"]) > 0;
        }
      
        public static int InsertNewCountry(string countryName)
        {
            int rowsAffected = DBL.ExecuteDML($"insert into Country(Name) values('{countryName}')");
            return rowsAffected;
        }




    }
}