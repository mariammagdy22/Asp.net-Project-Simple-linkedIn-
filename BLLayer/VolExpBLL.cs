using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.BLLayer
{
    public class VolExpBLL
    {
        #region Get / Select
        public static DataTable GetAll()
        {
            return VolEperienceDAL.GetAll();
        }
        public static DataTable GetByUserID(Guid userID)
        {
            return VolEperienceDAL.GetByUserID(userID);
        }
        public static DataTable GetByVolExpID(int volExpID)
        {
            return VolEperienceDAL.GetByVolExpID(volExpID);
        }
        public static Object GetWorkName(Guid userID)
        {
            return VolEperienceDAL.GetWorkName(userID);
        }
        public static Object GetWorkDescription(Guid userID)
        {
            return VolEperienceDAL.GetWorkDescription(userID);
        }

        public static Object GetWorkRole(Guid userID)
        {
            return VolEperienceDAL.GetWorkRole(userID);
        }
        #endregion

        #region Add / Insert
        public static int AddWorkNameOnly(Guid userId, string volWorkName)
        {
            return VolEperienceDAL.AddWorkNameOnly(userId, volWorkName);
        }
        public static int AddAll(Guid userId, string volWorkName, string volWorkDescription, string role)
        {
            return VolEperienceDAL.AddAll(userId, volWorkName, volWorkName, role);
        }
        #endregion

        #region Update / Edit
        public static int Update(int volExpID, string volWorkName, string volWorkDescription, string role)
        {
            return VolEperienceDAL.Update(volExpID, volWorkName, volWorkDescription, role);
        }
        #endregion

        #region Delete / Remove
        public static int DeleteByUserID(Guid userId)
        {
            return VolEperienceDAL.DeleteByUserID(userId);
        }
        public static int DeleteByWorkId(int id)
        {
            return VolEperienceDAL.DeleteByWorkId(id);
        }
        #endregion
    }
}