using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class LanguageDAL
    {
        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery("select * from Language");
            return dt;
        }

        public static DataTable GetById(int LanguageId)
        {

            DataTable dt = DBL.ExecuteQuery("select * from Language where Language.LanguageId = " + LanguageId);
            return dt;
        }

        public static DataTable GetByLangName(string LangName)
        {

            DataTable dt = DBL.ExecuteQuery("select * from Language where Language.LangName = " + LangName);
            return dt;
        }

        public static DataTable InsertLang (string LangName)
            {
            DataTable dt = DBL.ExecuteQuery("insert into Language(LangName) values ('" + LangName+"')");
            return dt;
        }

        //public static int insertLanguage(string UserId, int LanguageId)
        //{
        //    int rowsAffected = DBL.ExecuteDML("insert into UserLanguage (Fk_UserId, FK_LanguageId) values ('" + UserId + "', " + LanguageId + ")");
        //    return rowsAffected;
        //}


        //////*******/////////UserLanguageDAL///////************////////

        public static DataTable GetAlluserlang()
        {
            DataTable dt = DBL.ExecuteQuery("select * from UserLanguage  inner join Language on UserLanguage.Fk_LanguageId=Language.LanguageId  join LanguageLevel on LanguageLevel.LanguageLevelId= UserLanguage.FK_LanguageLevel");
            return dt;
        }

        //public static DataTable GetAlluserlang()
        //{
        //    DataTable dt = DBL.ExecuteQuery("select * from UserLanguage  inner join Language on UserLanguage.Fk_LanguageId=Language.LanguageId");
        //    return dt;
        //}




        internal static int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public static DataTable GetByUserLangId(int UserLanguageId )
        {

            DataTable dt = DBL.ExecuteQuery("select FK_UserId,UserLanguageId,LangName,FK_LanguageLevel  from aspnet_Users join UserLanguage on aspnet_Users.UserId=UserLanguage.FK_UserId join Language on Language.LanguageId = UserLanguage.UserLanguageId order by UserLanguage.UserLanguageId" + UserLanguageId);
            return dt;
        }

        public static DataTable GetToView(Guid FK_UserId)
        {

            DataTable dt = DBL.ExecuteQuery($"select UserId,FK_UserId ,LangName,LanguageLevelName from Language join UserLanguage  on Language.LanguageId = UserLanguage.UserLanguageId join LanguageLevel on LanguageLevel.LanguageLevelId = UserLanguage.FK_LanguageLevel join aspnet_Users on aspnet_Users.UserId =  '{FK_UserId}'");
                                          
            return dt;
        }



        public static DataTable GetByFK_UserId(int FK_UserId)
        {

            DataTable dt = DBL.ExecuteQuery("select FK_UserId,FK_LanguageId,LangName  from aspnet_Users join UserLanguage on aspnet_Users.UserId=UserLanguage.FK_UserId join Language on Language.LanguageId = UserLanguage.UserLanguageId order by UserLanguage.UserLanguageId" + FK_UserId);
            return dt;
        }

        public static DataTable GetByFK_UserIdd(Guid FK_UserId)
        {

            DataTable dt = DBL.ExecuteQuery("select FK_UserId,FK_LanguageId,LangName  from aspnet_Users join UserLanguage on aspnet_Users.UserId=UserLanguage.FK_UserId join Language on Language.LanguageId = UserLanguage.UserLanguageId order by UserLanguage.UserLanguageId" + FK_UserId);
            return dt;
        }

        public static int insertUserLanguage(Guid Fk_UserId, string FK_LanguageId)
        {
            int rowsAffected = DBL.ExecuteDML("insert into UserLanguage (Fk_UserId, FK_LanguageId) values ('" + Fk_UserId + "', " + FK_LanguageId + ")");
            return rowsAffected;
        }

        public static int DeleteUserLanguage(int FK_LanguageId)
        {
            int rowsAffected = DBL.ExecuteDML("delete UserLanguage where UserLanguage.Fk_LanguageId=" + FK_LanguageId);
            return rowsAffected;
        }
        public static int DeleteUserLanguagee(string FK_LanguageId)
        {
            int rowsAffected = DBL.ExecuteDML("delete UserLanguage where UserLanguage.Fk_LanguageId=" + FK_LanguageId);
            return rowsAffected;
        }

        ///////////////////////////////////////////

        public static DataTable GetAllLevells()
        {
            DataTable dt = DBL.ExecuteQuery("select * from LanguageLevel");
            return dt;
        }

        public static int insertUserLanguageLevel(Guid Fk_UserId, string FK_LanguageLevel)
        {
            int rowsAffected = DBL.ExecuteDML("insert into UserLanguage (Fk_UserId, FK_LanguageLevel) values ('" + Fk_UserId + "', " + FK_LanguageLevel + ")");
            return rowsAffected;
        }
        public static int InsertIdLevelUser (Guid Fk_UserId, string FK_LanguageLevel, string FK_LanguageId)
        {
            int rowsAffected = DBL.ExecuteDML("insert into UserLanguage (Fk_UserId, FK_LanguageLevel,FK_LanguageId) values ('" + Fk_UserId + "', " + FK_LanguageLevel + " ,'" + FK_LanguageId + "')");
            return rowsAffected;
        }
        public static int Updatelang(int FK_LanguageId, int FK_LanguageLevel, int UserLanguageId)
        {
            int rowsAffected = DBL.ExecuteDML($"update  UserLanguage set FK_LanguageId = '{FK_LanguageId}' , FK_LanguageLevel = '{FK_LanguageLevel}' where UserLanguageId = '{UserLanguageId}' ");
            return rowsAffected;
        }


    }
}