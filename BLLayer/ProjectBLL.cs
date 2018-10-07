using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.BLLayer
{
    public class ProjectBLL
    {
        #region Get / Select
        public static DataTable GetAll()
        {
            return ProjectDAL.GetAll();
        }

        public static DataTable GetAllByUserID(Guid userID)
        {
            return ProjectDAL.GetAllByUserID(userID);
        }

        public static DataTable GetAllByProjectID(Guid userID)
        {
            return ProjectDAL.GetAllByProjectID(userID);
        }

        public static Object GetProjectNameByUserID(Guid userID)
        {
            return ProjectDAL.GetProjectNameByUserID(userID);
        }
        public static Object GetStartDate(Guid userID)
        {
            return ProjectDAL.GetStartDate(userID);
        }

        public static Object GetEndDate(Guid userID)
        {
            return ProjectDAL.GetEndDate(userID);
        }

        public static Object GetProjectDescription(Guid userID)
        {
            return ProjectDAL.GetProjectDescription(userID);
        }
        #endregion

        #region Add / Insert
        public static int AddProject(Guid userId, string projectName, string description, string startDate, string endDate)
        {
            return ProjectDAL.AddProject(userId, projectName, description, startDate, endDate);
        }
        #endregion

        #region Update / Edit
        public static int Update(int projectId, string projectName, string description, string startDate, string endDate)
        {
            return ProjectDAL.Update(projectId, projectName, description, startDate, endDate);
        }
        #endregion

        #region Delete / Remove
        public static int Delete(int projectId)
        {
            return ProjectDAL.Delete(projectId);
        }
        #endregion
    }
}