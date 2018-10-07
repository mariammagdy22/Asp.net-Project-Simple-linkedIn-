using System;
using LinkedIN.DBLayer;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class ConnectionDAL
    {
        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery("select * from ConnectionRequest");
            return dt;
        }

        public static DataTable GetCommingRequests(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select * from ConnectionRequest where FK_UserToId = '{UserId}'");
            return dt;
        }

        public static DataTable GetSentRequests(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select * from ConnectionRequest where FK_UserFromId = '{UserId}'");
            return dt;
        }

        public static int AddnewConnection(Guid From, Guid To)
        {
            int rowsAffected = DBL.ExecuteDML($"insert into ConnectionRequest (FK_UserFromId,FK_UserToId,[Status]) values ('{From}','{To}','Waiting')");
            return rowsAffected;
        }

        public static int ModifyConnectionAccepted(int ConnId)
        {
            int rowsAffected = DBL.ExecuteDML($"update ConnectionRequest set [Status] = 'Connected' where ConnectionRequestId = {ConnId}");
            return rowsAffected;
        }

        public static int ModifyConnectionAccepted(Guid fromId ,Guid toId)
        {
            int rowsAffected = DBL.ExecuteDML($"update ConnectionRequest set [Status] = 'Connected'  where( FK_UserFromId = '{fromId}' and FK_UserToId = '{toId}')");
            return rowsAffected;
        }

        public static int ModifyConnectionRejected(int ConnId)
        {
            int rowsAffected = DBL.ExecuteDML($"update ConnectionRequest set [Status] = 'Disconnected' where ConnectionRequestId = {ConnId}");
            return rowsAffected;
        }

        public static int ModifyConnectionRejected(Guid fromId, Guid toId)
        {
            int rowsAffected = DBL.ExecuteDML($"update ConnectionRequest set [Status] = 'Disconnected'  where( FK_UserFromId = '{fromId}' and FK_UserToId = '{toId}')");
            return rowsAffected;
        }

        public static int DeleteReplicate()
        {
            int rowsAffected = DBL.ExecuteDML($"DELETE FROM ConnectionRequest WHERE ConnectionRequestId not in (SELECT MIN(ConnectionRequestId) FROM ConnectionRequest GROUP BY FK_UserFromId, FK_UserToId)");
            return rowsAffected;
        }

        public static int DeleteConnectionBetween(Guid id1,Guid id2)
        {
            int rowsAffected = DBL.ExecuteDML($"DELETE FROM ConnectionRequest WHERE (FK_UserFromId = '{id1}' and FK_UserToId = '{id2}') or (FK_UserFromId = '{id2}' and FK_UserToId = '{id1}')");
            return rowsAffected;
        }
        public static int DeleteConnectionById(int connId)
        {
            int rowsAffected = DBL.ExecuteDML($"DELETE FROM ConnectionRequest WHERE ConnectionRequestId = {connId}");
            return rowsAffected;
        }

        public static int DeleteConnectionFromTo(Guid fromId, Guid toId)
        {
            int rowsAffected = DBL.ExecuteDML($"DELETE FROM ConnectionRequest WHERE (FK_UserFromId = '{fromId}' and FK_UserToId = '{toId}')");
            return rowsAffected;
        }

        public static DataTable GetAllTo(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select * from ConnectionRequest inner join aspnet_Users on ConnectionRequest.FK_UserFromId=aspnet_Users.UserId WHERE  FK_UserToId = '{UserId}'");
            return dt;
        }

        public static DataTable GetAllToAndWaiting(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select* from ConnectionRequest inner join aspnet_Users on ConnectionRequest.FK_UserFromId=aspnet_Users.UserId WHERE(FK_UserToId = '{UserId}' and Status = 'Waiting')");
            return dt;
        }

        

        public static DataTable GetAllFrom(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select * from ConnectionRequest inner join aspnet_Users on ConnectionRequest.FK_UserToId=aspnet_Users.UserId WHERE  FK_UserFromId = '{UserId}'");
            return dt;
        }

        public static DataTable GetAllFromAndWaiting(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select* from ConnectionRequest inner join aspnet_Users on ConnectionRequest.FK_UserToId=aspnet_Users.UserId WHERE(FK_UserFromId = '{UserId}' and Status = 'Waiting')");
            return dt;
        }

        

        public static int ConnectFromTo(Guid from ,Guid to)
        {
            int rowsAffected = DBL.ExecuteDML($"update ConnectionRequest set [Status] = 'Connected' where( FK_UserFromId = '{from}' and FK_UserToId = '{to}')");
            return rowsAffected;
        }

        public static int DisconnectFromTo(Guid from, Guid to)
        {
            int rowsAffected = DBL.ExecuteDML($"update ConnectionRequest set [Status] = 'Disconnected' where( FK_UserFromId = '{from}' and FK_UserToId = '{to}')");
            return rowsAffected;
        }

        public static bool CheckFromTo(Guid from, Guid to)
        {
            DataTable dt = DBL.ExecuteQuery($"select count(FK_UserFromId) as NCount from ConnectionRequest where (FK_UserFromId = '{from}' and FK_UserToId = '{to}')");
            return Convert.ToInt32(dt.Rows[0]["NCount"])>0;
        }

        public static DataTable GetUserConnections(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery($"select FK_UserFromId as friendId,UserName,[Status] from ConnectionRequest inner join aspnet_Users on ConnectionRequest.FK_UserFromId = aspnet_Users.UserId where (FK_UserToId = '{UserId}' and[Status] = 'Connected') union select FK_UserToId as friendId, UserName,[Status] from ConnectionRequest inner join aspnet_Users on ConnectionRequest.FK_UserToId = aspnet_Users.UserId where (FK_UserFromId = '{UserId}' and[Status] = 'Connected')");
            return dt;
        }

    }
}