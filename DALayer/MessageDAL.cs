using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class MessageDAL
    {
        public static DataTable GetAllTableMsg()
        {
            DataTable dt = DBL.ExecuteQuery("select * from Message");
            return dt;
        }

        public static DataTable GetAllMsgBw(Guid UserId,Guid otherId)
        {
            DataTable dt = DBL.ExecuteQuery($"select UserName,Text ,Date from Message join aspnet_Users on Message.FK_FromId = aspnet_Users.UserId where(FK_FromId = '{UserId}' and FK_ToId = '{otherId}') or (FK_FromId = '{otherId}' and FK_ToId = '{UserId}')");
            return dt;
        }





        public static DataTable GetAllUsers()
        {
            DataTable dt = DBL.ExecuteQuery("select UserName ,UserId from aspnet_Users");
            return dt;
        }
        public static DataTable deleteMessage(string MessageId)
        {
            DataTable dt = DBL.ExecuteQuery("delete  Message where MessageId= " + MessageId);
            return dt;
        }

        public static DataTable GetMsgByFKToId(int Fk_FromId , int FK_ToId )
        {
            DataTable dt = DBL.ExecuteQuery("select Text from Message where Fk_FromId and FK_ToId='" + Fk_FromId + "', " + FK_ToId + ")");
            return dt;
        }


        public static DataTable GetMsgBySelection (int FK_FromId, int FK_ToId)
        {
            DataTable dt = DBL.ExecuteQuery("select Distinct  UserName , Text,Date from aspnet_Users join Message on UserId = FK_FromId or UserId = FK_ToId='" + FK_FromId + "', " + FK_ToId + ")");
            return dt;
        }

        public static DataTable AddMsg(Guid FK_FromId,Guid FK_ToId,string msg,string date)
        {
            DataTable dt = DBL.ExecuteQuery($"insert into  Message (FK_FromId,FK_ToId,[Text],[Date]) values ('{FK_FromId}','{FK_ToId}','{msg}','{date}')");
           return dt;
        }



    }
}