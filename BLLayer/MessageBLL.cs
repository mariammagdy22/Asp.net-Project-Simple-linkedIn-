using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.BLLayer
{
    public class MessageBLL
    {
        public static DataTable GetAllTableMsg()
        {
            return MessageDAL.GetAllTableMsg();
        }

        public static DataTable GetAllMsgBw(Guid UserId, Guid otherId)
        {
            return MessageDAL.GetAllMsgBw( UserId,  otherId);
        }



        public static DataTable GetAllUsers()
        {
            return MessageDAL.GetAllUsers();
        }


        public static DataTable deleteMessage(string MessageId)
        {
            return MessageDAL.deleteMessage (MessageId);
        }

        public static DataTable GetMsgByFKToId(int Fk_FromId, int FK_ToId)
        {
            return MessageDAL.GetMsgByFKToId(Fk_FromId, FK_ToId);
        }

        public static DataTable GetMsgBySelection(int FK_FromId, int FK_ToId)
        {
            return MessageDAL.GetMsgBySelection(FK_FromId, FK_ToId);
        }
        public static DataTable AddMsg(Guid FK_FromId, Guid FK_ToId, string msg, string date)
        {
            return MessageDAL.AddMsg( FK_FromId,  FK_ToId,  msg, date);
        }



    }
}