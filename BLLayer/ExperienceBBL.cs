using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.BLLayer
{
    public class ExperienceBLL
    {
        public static DataTable GetAllExperience()
        {            
            return ExperienceDAL.GetAllExperience();
        }
        // select user experience by id
        public static DataTable GetAllUserExperienceById(Guid UserId)
        {            
            return ExperienceDAL.GetAllUserExperienceById(UserId);
        }
        //Insert All At User Work Experience
        public static int InsertNewUserExperience(Guid FK_UserId, string Country, string Company, string Title, string StartingDate)
        {
            return ExperienceDAL.InsertNewUserExperience(FK_UserId, Country, Company, Title, StartingDate);
        }
        // delete 
        public static int RemoveUserExperience(Guid UserId)
        {         
            return ExperienceDAL.RemoveUserExperience(UserId);
        }
        //Update
        public static int UpdateUserExperience(Guid FK_UserId, int Country, int Company, string Title, string StartingDate)
        {
            return ExperienceDAL.UpdateUserExperience(FK_UserId, Country, Company, Title, StartingDate);
        }

    }
}