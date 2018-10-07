using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class ProjectDAL
    {
        #region Get / Select
        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery("select * from Project");
            return dt;
        }
        public static DataTable GetAllByUserID (Guid userID)
        {
            //DataTable dt = DBL.ExecuteQuery($"select * from Project inner join UserProject on Project.ProjectId=UserProject.FK_ProjectId inner join aspnet_Users on aspnet_Users.UserId=UserProject.FK_ProjectId where aspnet_Users.UserId = {userID}");
            DataTable dt = DBL.ExecuteQuery($"select * from Project where FK_UserId='{userID}'");

            return dt;
        }
        public static DataTable GetAllByProjectID (Guid userID)
        {
            DataTable dt = DBL.ExecuteQuery($"select * from Project where FK_UserId='{userID}'");
            return dt;
        }

        public static Object GetProjectNameByUserID (Guid userID)
        {
            Object cell = DBL.ExecuteScalar($"select ProjectName from Project where FK_UserId='{userID}'");
            return cell;
        }
        public static Object GetStartDate(Guid userID)
        {
            Object cell = DBL.ExecuteScalar($"select StartDate from Project where FK_UserId='{userID}'");
            return cell;
        }

        public static Object GetEndDate(Guid userID)
        {
            Object cell = DBL.ExecuteScalar($"select EndDate from Project where FK_UserId='{userID}'");
            return cell;
        }

        public static Object GetProjectDescription(Guid userID)
        {
            Object cell = DBL.ExecuteScalar($"select Description from Project where FK_UserId='{userID}'");
            return cell;
        }
        #endregion

        #region Add / Insert
        public static int AddProject (Guid userId, string projectName, string description, string startDate, string endDate)
        {
            int rowsAffected = DBL.ExecuteDML($"insert into Project (ProjectName, Description, StartDate, EndDate, FK_UserId) values ('{projectName}', '{description}', '{startDate}', '{endDate}', '{userId}') ");
            return rowsAffected;
        }
        #endregion

        #region Update / Edit
        public static int Update (int projectId, string projectName, string description, string startDate, string endDate)
        {
            int rowsAffected = DBL.ExecuteDML($"update Project set ProjectName = '{projectName}' , Description = '{description}', StartDate = '{startDate}', EndDate = '{endDate}' where ProjectId = '{projectId}' ");
            return rowsAffected;
        }
        #endregion

        #region Delete / Remove
        public static int Delete (int projectId)
        {
            int rowsAffected = DBL.ExecuteDML($"Delete from Project where ProjectId = '{projectId}'");
            return rowsAffected;
        }
        #endregion
    }
}