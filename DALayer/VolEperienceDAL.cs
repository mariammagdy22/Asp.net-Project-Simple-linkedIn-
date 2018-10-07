using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class VolEperienceDAL
    {
        #region Get / Select
        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery("select * from VolExperience");
            return dt;
        }
        public static DataTable GetByUserID(Guid userID)
        {
            DataTable dt = DBL.ExecuteQuery($"select * from VolExperience where FK_UserId='{userID}'");
            return dt;
        }
        public static DataTable GetByVolExpID(int volExpID)
        {
            DataTable dt = DBL.ExecuteQuery($"select * from VolExperience where Id='{volExpID}'");
            return dt;
        }
        public static Object GetWorkName(Guid userID)
        {
           Object cell = DBL.ExecuteScalar($"select VolWorkName from VolExperience where FK_UserId='{userID}'");
            return cell;
        }
        public static Object GetWorkDescription(Guid userID)
        {
            Object cell = DBL.ExecuteScalar($"select volWorkDescription from VolExperience where FK_UserId='{userID}'");
            return cell;
        }

        public static Object GetWorkRole(Guid userID)
        {
            Object cell = DBL.ExecuteScalar($"select Role from VolExperience where FK_UserId='{userID}'");
            return cell;
        }
        #endregion

        #region Add / Insert
        public static int AddWorkNameOnly (Guid userId, string volWorkName)
        {
            int rowsAffected = DBL.ExecuteDML($"insert into VolExperience (VolWorkName, FK_UserId) values ('{volWorkName}', '{userId}')");
            return rowsAffected;
        }
        public static int AddAll (Guid userId, string volWorkName, string volWorkDescription ,string role)
        {
            int rowsAffected = DBL.ExecuteDML($"insert into VolExperience (VolWorkName, VolWorkDescription, Role, FK_UserId) values ('{volWorkName}', '{volWorkDescription}', '{role}', '{userId}')");
            return rowsAffected;
        }
        #endregion

        #region Update / Edit
        public static int Update (int VolExpID, string volWorkName, string volWorkDescription, string role)
        {
            int rowsAffected = DBL.ExecuteDML($"update VolExperience set VolWorkName = '{volWorkName}' , VolWorkDescription = '{volWorkDescription}' , Role= '{role}' where VolExperienceId = '{VolExpID}'");
            return rowsAffected;
        }
        #endregion

        #region Delete / Remove
        public static int DeleteByUserID (Guid userId)
        {
            int rowsAffected = DBL.ExecuteDML($"Delete from VolExperience where FK_UserId = '{userId}'");
            return rowsAffected;
        }
        public static int DeleteByWorkId(int id)
        {
            int rowsAffected = DBL.ExecuteDML($"Delete from VolExperience where VolExperienceId = '{id}'");
            return rowsAffected;
        }
        #endregion

    }
}