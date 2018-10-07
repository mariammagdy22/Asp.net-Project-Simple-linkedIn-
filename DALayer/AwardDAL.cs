using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinkedIN.DBLayer;
using System.Data;

namespace LinkedIN.DALayer
{
    public class AwardDAL
    {

        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery("select * from Award");

            return dt;
        }

        public static DataTable GetByAwardId(string Id)
        {

            DataTable dt = DBL.ExecuteQuery("select * from Award where Award.AwardId = " + Id);


            return dt;
        }
        public static DataTable GetByUserId(Guid Id)
        {

            DataTable dt = DBL.ExecuteQuery("select * from Award where Award.FK_UserId = '"+Id+"' ");


            return dt;
        }
        public static int insertUserAward( string AwardName,string Date,string Provider,Guid UserId)
        {
            int rowsAffected = DBL.ExecuteDML("insert into Award (AwardName,AwardDate,AwardProvider,FK_UserId) values('" + AwardName + "','" + Date + "','" + Provider + "','" + UserId + "' ) ");

            return rowsAffected;
        }



        //public static int GetLatestId()
        //{
        //    object PicId = DBL.ExecuteScalar("select PicturesDB.Id  from PicturesDB where PicturesDB.Id=(select max(PicturesDB.Id) from PicturesDB)");
        //    return Convert.ToInt32(PicId);
        //}
        //public static int AddandGetId(string fileName, int fileSize, byte[] bytes)
        //{
        //    string procName = "sqlUploadPicture";
        //    int newPicId = DBL.AddImage(procName, fileName, fileSize, bytes);
        //    return newPicId;
        //}
        //public static int Update(int Id, int fileSize, byte[] bytes)
        //{
        //    int rowsAffected = DBL.ExecuteDML("update Pictures set Size='" + fileSize + "' , ImageData=" + bytes + " where Id=" + Id);
        //    return rowsAffected;
        //}
        public static int Remove(int Id)
        {
            int rowsAffected = DBL.ExecuteDML("delete from Award where FK_UserId =" + Id);
            return rowsAffected;
        }


    }
}