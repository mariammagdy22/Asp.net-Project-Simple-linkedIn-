using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinkedIN.DBLayer;
using System.Data;


namespace LinkedIN.DALayer
{
    public class PictureDAL
    {
        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery("select PicturesDB.Id as PictureId ,PicturesDB.Size,PicturesDB.ImageData from PicturesDB");
            return dt;
        }

        public static DataTable GetById(int Id)
        {
            DataTable dt = DBL.ExecuteQuery("  select PicturesDB.Id as PictureId ,PicturesDB.Size,PicturesDB.ImageData from PicturesDB where PicturesDB.Id=" + Id);
            return dt;
        }

        public static object GetImageOnlyById(int Id)
        {
            object _Object = DBL.ExecuteScalar("  select PicturesDB.ImageData from PicturesDB where PicturesDB.PictureId=" + Id);
            return _Object;
        }

        public static object GetImageOnlyByUserId(Guid userId)
        {
            object _Object = DBL.ExecuteScalar($"select top 1 PicturesDB.ImageData from PicturesDB where PicturesDB.FK_UserIdAddedBy='{userId}' ORDER BY PicturesDB.PictureId DESC");
            return _Object;
        }
        public static int GetLatestId()
        {
            object PicId = DBL.ExecuteScalar("select PicturesDB.Id  from PicturesDB where PicturesDB.Id=(select max(PicturesDB.Id) from PicturesDB)");
            return Convert.ToInt32(PicId);
        }
        public static int AddandGetId(string fileName,int fileSize, byte[] bytes,Guid userId)
        {
            string procName = "sqlUploadPicturByUser";
            int newPicId = DBL.AddImage(procName, fileName, fileSize, bytes,userId);
            return newPicId;
        }

        public  static int AddPictureUser(int picId,Guid UserId)
        {
            int rowsAffected = DBL.ExecuteDML($"update PicturesDB set FK_UserIdAddedBy = '{UserId}' where PictureId = {picId}");
            return rowsAffected;
        }

        //public static int Update(int Id, int fileSize, byte[] bytes)
        //{
        //    int rowsAffected = DBL.ExecuteDML("update Pictures set Size='" + fileSize + "' , ImageData=" + bytes + " where Id=" + Id);
        //    return rowsAffected;
        //}
        public static int Remove(int Id)
        {
            int rowsAffected = DBL.ExecuteDML("delete from PicturesDB where Id=" + Id);
            return rowsAffected;
        }
    }
}