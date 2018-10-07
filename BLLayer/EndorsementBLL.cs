using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinkedIN.DALayer;
using System.Data;

namespace LinkedIN.BLLayer
{
    public class EndorsementBLL
    {
        public static DataTable GetAll()
        {
            return EndorsementDAL.GetAll();
        }
        public static int Add(string FK_SkillId, Guid FK_UserFromId, Guid FK_UserToId)
        {
            return EndorsementDAL.Add( FK_SkillId,  FK_UserFromId,  FK_UserToId);
        }
        public static int RemovebyParams(string FK_SkillId, Guid FK_UserFromId, Guid FK_UserToId)
        {
            return EndorsementDAL.RemovebyParams( FK_SkillId,  FK_UserFromId,  FK_UserToId);
        }
        public static int RemovebyId(string EndorsementId)
        {
            return EndorsementDAL.RemovebyId( EndorsementId);
        }
        public static bool CheckEndorsement(string FK_SkillId, Guid FK_UserFromId, Guid FK_UserToId)
        {
            return EndorsementDAL.CheckEndorsement( FK_SkillId,  FK_UserFromId,  FK_UserToId);
        }
    }
}