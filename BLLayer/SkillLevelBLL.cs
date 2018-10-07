using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinkedIN.DALayer;
using System.Data;

namespace LinkedIN.BLLayer
{
    public class SkillLevelBLL
    {
        public static DataTable GetAll()
        {
            return SkillLevelDAL.GetAll();
        }

        public static DataTable GetById(string Id)
        {
            return SkillLevelDAL.GetById( Id);
        }

        public static int Add(string newName)
        {
            return SkillLevelDAL.Add( newName);
        }

        public static int UpdatebyId(string newName, string skillId)
        {
            return SkillLevelDAL.UpdatebyId( newName,  skillId);
        }

        public static int UpdatebyName(string newName, string oldName)
        {
            return SkillLevelDAL.UpdatebyName( newName,  oldName);
        }

        public static int RemoveById(string skillId)
        {
            return SkillLevelDAL.RemoveById( skillId);
        }

        public static int RemoveByName(string skillName)
        {
            return SkillLevelDAL.RemoveByName( skillName);
        }
    }
}