using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinkedIN.DBLayer;
using System.Data;

namespace LinkedIN.DALayer
{
    public class UserDAL
    {

        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery("select * from aspnet_Users  inner join UserFull on aspnet_Users.UserId=UserFull.FK_UserId");
            return dt;
        }

        public static DataTable GetAllExcept(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select * from aspnet_Users WHERE NOT (UserId = '{UserId}')");
            return dt;
        }

        public static DataTable GetById(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select *,Country.Name as CountryName from aspnet_Users  left join UserFull on aspnet_Users.UserId=UserFull.FK_UserId left join Country on UserFull.FK_CountryId = Country.CountryId where aspnet_Users.UserId = '{UserId}'");
            return dt;
        }

        public static int InsertUserCountryAndPostalCode(Guid UserId, int postalCode, string CountryId)
        {
            int rowsAffected = DBL.ExecuteDML($"insert into UserFull (Fk_UserId,PostalCode, FK_CountryId) values ('{UserId}', '{postalCode}', {CountryId})");
            return rowsAffected;
        }

        public static int UpdateUserProfilePic(Guid userId,int picId)
        {
            int rowsAffected = DBL.ExecuteDML($"update UserFull set FK_ProfilePhotoId = {picId} where FK_UserId = '{userId}'");
            return rowsAffected;
        }

        public static int UpdateUserCoverPic(Guid userId, int picId)
        {
            int rowsAffected = DBL.ExecuteDML($"update UserFull set FK_ProfilePhotoId = {picId} where FK_UserId = '{userId}'");
            return rowsAffected;
        }

        
        
        public static int Remove(string Id)
        {
            int rowsAffected = DBL.ExecuteDML("delete from PicturesDB where Id=" + Id);
            return rowsAffected;
        }

        public static bool CheckUserFullInserted( Guid FK_UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select count(FK_UserId) as NCount from UserFull where FK_UserId = '{FK_UserId}'");
            return Convert.ToInt32(dt.Rows[0]["NCount"]) > 0;
        }

        public static int InsertUserfullData(Guid FK_UserId,string PostalCode,string FK_CountryId,string Summary)
        {
            int rowsAffected = DBL.ExecuteDML($"insert into UserFull(FK_UserId, PostalCode, FK_CountryId, Summary) values('{FK_UserId}','{PostalCode}','{FK_CountryId}','{Summary}')");
            return rowsAffected;
        }

        public static int UpdateUserfullData(Guid FK_UserId, string PostalCode, string FK_CountryId, string Summary)
        {
            int rowsAffected = DBL.ExecuteDML($"Update UserFull set PostalCode='{PostalCode}',FK_CountryId={FK_CountryId},Summary='{Summary}' WHERE FK_UserId = '{FK_UserId}'");
            return rowsAffected;
        }

        public static int InsertUserSummary(Guid FK_UserId, string Summary)
        {
            int rowsAffected = DBL.ExecuteDML($"insert into UserFull(FK_UserId, Summary) values('{FK_UserId}','{Summary}')");
            return rowsAffected;
        }

        public static int UpdateUserSummary(Guid FK_UserId, string Summary)
        {
            int rowsAffected = DBL.ExecuteDML($"Update UserFull set Summary = '{Summary}' WHERE FK_UserId = '{FK_UserId}'");
            return rowsAffected;
        }


        public static DataTable GetPeopleYouMayKnow(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"SELECT* FROM aspnet_Users WHERE UserId NOT IN ( select FK_UserFromId as friendId from ConnectionRequest inner join aspnet_Users on ConnectionRequest.FK_UserFromId = aspnet_Users.UserId where (FK_UserToId = '{UserId}' and([Status] = 'Connected' or[Status] = 'Waiting')) union select FK_UserToId as friendId from ConnectionRequest inner join aspnet_Users on ConnectionRequest.FK_UserToId = aspnet_Users.UserId where (FK_UserFromId = '{UserId}' and([Status] = 'Connected' or[Status] = 'Waiting')) union select UserId from aspnet_Users where UserId = '{UserId}')");
            return dt;
        }
        
    }
}