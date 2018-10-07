using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinkedIN.DALayer;
using System.Data;

namespace LinkedIN.BLLayer
{
    public class SkillBLL
    {
        public static DataTable GetAll()
        {
            return SkillDAL.GetAll();
        }
        public static DataTable GetByUserID(Guid FK_UserId)
        {
            return SkillDAL.GetByUserID( FK_UserId);
        }
        public static int Add(string SkillName, string FK_SkillLevelId, Guid FK_UserId)
        {
            return SkillDAL.Add( SkillName,  FK_SkillLevelId,  FK_UserId);
        }
        public static int Update(string SkillName, string FK_SkillLevelId, string SkillId)
        {
            return SkillDAL.Update( SkillName,  FK_SkillLevelId,  SkillId);
        }
        public static int Endorse(string SkillId)
        {
            return SkillDAL.Endorse( SkillId);
        }
        public static int De_Endorse(string SkillId)
        {
            return SkillDAL.De_Endorse( SkillId);
        }
        public static int Remove(string SkillId)
        {
            return SkillDAL.Remove( SkillId);
        }
        public static DataTable GetSkillEndorsers(string SkillID)
        {
            return SkillDAL.GetSkillEndorsers( SkillID);
        }
    }
}