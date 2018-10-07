using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class SkillDAL
    {


        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery($"select * from Skill inner join SkillLevel on Skill.FK_SkillLevelId=SkillLevel.SkillLevelId");
            return dt;
        }
        public static DataTable GetByUserID(Guid FK_UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select * from Skill inner join SkillLevel on Skill.FK_SkillLevelId=SkillLevel.SkillLevelId where FK_UserId = '{FK_UserId}'");
            return dt;
        }        
        public static int Add(string SkillName,string FK_SkillLevelId,Guid FK_UserId)
        {        
            int rowsAffected = DBL.ExecuteDML($"insert into Skill(SkillName, FK_SkillLevelId, FK_UserId, SkillCounter) values('{SkillName}',{FK_SkillLevelId},'{FK_UserId}',0)");
            return rowsAffected;
        }
        public static int Update(string SkillName, string FK_SkillLevelId, string SkillId)
        {
            int rowsAffected = DBL.ExecuteDML($"Update Skill set SkillName = '{SkillName}', FK_SkillLevelId = {FK_SkillLevelId} WHERE SkillId = {SkillId}");
            return rowsAffected;
        }
        public static int Endorse(string SkillId)
        {
            int rowsAffected = DBL.ExecuteDML($"UPDATE Skill SET SkillCounter = SkillCounter + 1 WHERE SkillId = {SkillId}");
            return rowsAffected;
        }
        public static int De_Endorse(string SkillId)
        {
            int rowsAffected = DBL.ExecuteDML($"UPDATE Skill SET SkillCounter = SkillCounter - 1 WHERE SkillId = {SkillId}");
            return rowsAffected;
        }
        public static int Remove(string SkillId)
        {
            int rowsAffected = DBL.ExecuteDML($"delete from Skill where SkillId = {SkillId}");
            return rowsAffected;
        }

        public static DataTable GetSkillEndorsers(string SkillID)
        {
            DataTable dt = DBL.ExecuteQuery($"select* from Endorsement inner join Skill on Endorsement.FK_SkillId = Skill.SkillId inner join aspnet_Users on Endorsement.FK_UserFromId = aspnet_Users.UserId where SkillId = {SkillID}");
            return dt;
        }
        






    }
}