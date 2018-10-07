using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class EndorsementDAL
    {
        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery($"select* from Endorsement");
            return dt;
        }
        public static int Add(string FK_SkillId, Guid FK_UserFromId, Guid FK_UserToId)
        {
            int rowsAffected = DBL.ExecuteDML($"insert into Endorsement(FK_SkillId, FK_UserFromId, FK_UserToId) values({FK_SkillId},'{FK_UserFromId}','{FK_UserToId}')");
            return rowsAffected;
        }
        public static int RemovebyParams(string FK_SkillId, Guid FK_UserFromId, Guid FK_UserToId)
        {
            int rowsAffected = DBL.ExecuteDML($"delete from Endorsement where(FK_SkillId = {FK_SkillId} and FK_UserFromId = '{FK_UserFromId}' and FK_UserToId = '{FK_UserToId}')");
            return rowsAffected;
        }
        public static int RemovebyId(string EndorsementId)
        {
            int rowsAffected = DBL.ExecuteDML($"delete from Endorsement where EndorsementId={EndorsementId}");
            return rowsAffected;
        }         
        public static bool CheckEndorsement(string FK_SkillId,Guid FK_UserFromId, Guid FK_UserToId)
        {
            DataTable dt = DBL.ExecuteQuery($"select count(FK_UserFromId) as NCount from Endorsement where (FK_SkillId = {FK_SkillId} and FK_UserFromId = '{FK_UserFromId}' and FK_UserToId = '{FK_UserToId}')");
            return Convert.ToInt32(dt.Rows[0]["NCount"]) > 0;
        }
    }
}