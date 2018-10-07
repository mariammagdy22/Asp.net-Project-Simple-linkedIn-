using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class ExperienceDAL
    {
        //selectAll
        public static DataTable GetAllExperience()
        {
            DataTable dt = DBL.ExecuteQuery("select * from UserWorkExperience");
            return dt;
        } 
        // select user experience by id
        public static DataTable GetAllUserExperienceById(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery("select * from UserWorkExperience where FK_UserId='"+ UserId + "' ");
            return dt;
        }
        //Insert All At User Work Experience
        public static int InsertNewUserExperience(Guid FK_UserId, string Country, string Company, string Title,string StartingDate)
        {
            int rowsAffected = DBL.ExecuteDML("insert into UserWorkExperience (FK_UserId,Country,Company,Title,StartingDate) values('"+ FK_UserId + "','"+ Country + "','"+ Company + "','"+ Title + "','"+ StartingDate + "')");
            return rowsAffected;
        }
        // delete 
        public static int RemoveUserExperience(Guid UserId)
        {
            int rowsAffected = DBL.ExecuteDML("delete from UserWorkExperience where FK_UserId='"+UserId+"'");
            return rowsAffected;
        }        
        //Update
        public static int UpdateUserExperience(Guid FK_UserId, int Country, int Company, string Title, string StartingDate)
        {
            int rowsAffected = DBL.ExecuteDML("update UserWorkExperience set Title='"+ Title + "' , Country='"+ Country + "',Company='"+ Company + "',StartingDate='"+ StartingDate + "' where UserWorkExperience.FK_UserId='"+ FK_UserId + "'");
            return rowsAffected;
        }


    }
}