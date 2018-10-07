using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class SkillLevelDAL
    {
        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery("select * from SkillLevel");
            return dt;
        }

        public static DataTable GetById(string Id)
        {
            DataTable dt = DBL.ExecuteQuery($"select * from SkillLevel where SkillLevelId = {Id}");
            return dt;
        }
        public static int Add(string newName)
        {
            int rowsAffected = DBL.ExecuteDML($"insert into SkillLevel (SkillLevelName) values('{newName}')");
            return rowsAffected;
        }        
        public static int UpdatebyId(string newName, string skillId)
        {
            int rowsAffected = DBL.ExecuteDML($"update SkillLevel set SkillLevelName = '{newName}' where SkillLevelId = {skillId}");
            return rowsAffected;
        }

        public static int UpdatebyName(string newName, string oldName)
        {
            int rowsAffected = DBL.ExecuteDML($"update SkillLevel set SkillLevelName = '{newName}' where SkillLevelName = '{oldName}'");
            return rowsAffected;
        }

        public static int RemoveById(string skillId)
        {
            int rowsAffected = DBL.ExecuteDML($"DELETE FROM SkillLevel WHERE SkillLevelId = {skillId}");
            return rowsAffected;
        }

        public static int RemoveByName(string skillName)
        {
            int rowsAffected = DBL.ExecuteDML($"DELETE FROM SkillLevel WHERE SkillLevelName = '{skillName}'");
            return rowsAffected;
        }



    }
}