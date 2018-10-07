using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinkedIN.DALayer;
using System.Data;

namespace LinkedIN.BLLayer
{
    public class UserBLL
    {
        public static DataTable GetAll()
        {
            return UserDAL.GetAll();
        }

        public static DataTable GetById(Guid Id)
        {
            return UserDAL.GetById(Id);
        }

        public static int InsertUserCountryAndPostalCode(Guid UserId, int postalCode, string CountryId)
        {
            return UserDAL.InsertUserCountryAndPostalCode(UserId, postalCode,CountryId);
        }

        public static int UpdateUserProfilePic(Guid userId, int picId)
        {
            return UserDAL.UpdateUserProfilePic(userId, picId);
        }

        public static DataTable GetAllExcept(Guid UserId)
        {
            return UserDAL.GetAllExcept(UserId);
        }

        
        public static int Remove(string Id)
        {
            return UserDAL.Remove(Id);
        }

        public static bool CheckUserFullInserted(Guid FK_UserId)
        {
            return UserDAL.CheckUserFullInserted(FK_UserId);
        }

        public static int InsertUserfullData(Guid FK_UserId, string PostalCode, string FK_CountryId, string Summary)
        {
            return UserDAL.InsertUserfullData( FK_UserId,  PostalCode,  FK_CountryId,  Summary);
        }

        public static int UpdateUserfullData(Guid FK_UserId, string PostalCode, string FK_CountryId, string Summary)
        {
            return UserDAL.UpdateUserfullData( FK_UserId,  PostalCode,  FK_CountryId,  Summary);
        }

        public static int ModifyUserfullData(Guid FK_UserId, string PostalCode, string FK_CountryId, string Summary)
        {

            bool addedBefore= UserDAL.CheckUserFullInserted(FK_UserId);
            if (addedBefore)
            {
                return UserDAL.UpdateUserfullData(FK_UserId, PostalCode, FK_CountryId, Summary);
            }
            else
            {
                return UserDAL.InsertUserfullData(FK_UserId, PostalCode, FK_CountryId, Summary);
            }
            
        }

        public static int InsertUserSummary(Guid FK_UserId, string Summary)
        {
            return UserDAL.InsertUserSummary( FK_UserId,  Summary);
        }

        public static int UpdateUserSummary(Guid FK_UserId, string Summary)
        {
            return UserDAL.UpdateUserSummary( FK_UserId,  Summary);
        }

        public static int ModifyUserSummary(Guid FK_UserId, string Summary)
        {
            bool addedBefore = UserDAL.CheckUserFullInserted(FK_UserId);
            if (addedBefore)
            {
                return UserDAL.UpdateUserSummary(FK_UserId, Summary);
            }
            else
            {
                return UserDAL.InsertUserSummary(FK_UserId, Summary);
            }
        }

        public static DataTable GetPeopleYouMayKnow(Guid UserId)
        {
            return UserDAL.GetPeopleYouMayKnow( UserId);
        }

    }
}