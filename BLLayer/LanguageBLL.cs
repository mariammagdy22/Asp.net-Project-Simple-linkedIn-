using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.BLLayer
{
    public class LanguageBLL
    {
        public static DataTable GetAll()
        {
            return LanguageDAL.GetAll();
        }

        public static DataTable GetById(int LanguageId)
        {
            return LanguageDAL.GetById(LanguageId);
        }

        public static DataTable GetByLangName(string LangName)
        {
            return LanguageDAL.GetByLangName(LangName);
        }
        public static DataTable InsertLang (string LangName)
        {
            return LanguageDAL.InsertLang(LangName);
        }

        /////*********/////// UserLanguageBLL /////*********///////

        public static DataTable GetAlluserlang()
        {
            return LanguageDAL.GetAlluserlang();
        }
        public static  DataTable GetByUserLangId(int UserLanguageId)
        {
            return LanguageDAL.GetByUserLangId(UserLanguageId);
        }

        public static DataTable GetByFK_UserId(int FK_UserId)
        {
            return LanguageDAL.GetByFK_UserId(FK_UserId);

        }

        public static DataTable GetByFK_UserIdd(Guid FK_UserId)
        {
            return LanguageDAL.GetByFK_UserIdd(FK_UserId);

        }
        public static DataTable GetToView(Guid FK_UserId)
        {
            return LanguageDAL.GetToView(FK_UserId);

        }


        private static int Remove(int FK_UserId)
        {
            return LanguageDAL.Remove(FK_UserId);
        }

        public static int insertUserLanguage(Guid Fk_UserId, string FK_LanguageId)
        {
            return LanguageDAL.insertUserLanguage(Fk_UserId, FK_LanguageId);

        }

        public static int DeleteUserLanguage(int FK_LanguageId)
        {
            return LanguageDAL.DeleteUserLanguage(FK_LanguageId);

        }

        public static int DeleteUserLanguagee(string FK_LanguageId)
        {
            return LanguageDAL.DeleteUserLanguagee(FK_LanguageId);

        }



        public static DataTable GetAllLevells()
        {
            return LanguageDAL.GetAllLevells();
        }

        public static int insertUserLanguageLevel(Guid Fk_UserId, string FK_LanguageLevel)
        {
            return LanguageDAL.insertUserLanguage(Fk_UserId, FK_LanguageLevel);

        }
        public static int InsertIdLevelUser(Guid Fk_UserId, string FK_LanguageLevel, string FK_LanguageId)
        {
            return LanguageDAL.InsertIdLevelUser(Fk_UserId, FK_LanguageLevel, FK_LanguageId);

        }
        public static int Updatelang(int FK_LanguageId, int FK_LanguageLevel, int UserLanguageId)
        {
            return LanguageDAL.Updatelang(FK_LanguageId, FK_LanguageLevel, UserLanguageId);
        }


    }
}