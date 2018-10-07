using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using LinkedIN.DALayer;

namespace LinkedIN.BLLayer
{
    public class PictureBLL
    {
        public static DataTable GetAll()
        {            
            return PictureDAL.GetAll();
        }

        public static DataTable GetById(int Id)
        {
            return PictureDAL.GetById(Id);
        }

        public static object GetImageOnlyById(int Id)
        {
            return PictureDAL.GetImageOnlyById(Id);
        }
        public static int GetLatestId()
        {
            return PictureDAL.GetLatestId();
        }
        public static object GetImageOnlyByUserId(Guid userId)
        {
            return PictureDAL.GetImageOnlyByUserId(userId);
        }
        public static int AddandGetId(string fileName, int fileSize, byte[] bytes, Guid userId)
        {
            return PictureDAL.AddandGetId(fileName,  fileSize,  bytes, userId);
        }
        public static int AddPictureUser(int picId, Guid UserId)
        {
            return PictureDAL.AddPictureUser(picId, UserId);
        }
        //public static int Update(int Id, int fileSize, byte[] bytes)
        //{
        //    return PictureDAL.Update(Id,fileSize,bytes);
        //}
        public static int Remove(int Id)
        {
            return PictureDAL.Remove(Id);
        }
    }
}