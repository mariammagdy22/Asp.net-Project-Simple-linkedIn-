using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.BLLayer
{
    public class AwardBLL
    {
        public static DataTable GetAll()
        {


            return AwardDAL.GetAll();
        }

        public static DataTable GetByAwardId(string Id)
        {




            return AwardDAL.GetByAwardId(Id);
        }
        public static DataTable GetByUserId(Guid Id)
        {

            


            return AwardDAL.GetByUserId(Id) ;
        }
        public static int insertUserAward(string AwardName, string Date, string Provider, Guid UserId)
        {


            return AwardDAL.insertUserAward(AwardName, Date, Provider, UserId);
                
        }
        public static int Remove(int Id)
        {
            
            return AwardDAL.Remove(Id);
        }

    }
}