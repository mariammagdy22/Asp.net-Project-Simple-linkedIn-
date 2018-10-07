using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace LinkedIN.BLLayer
{
    public class ConnectionBLL
    {
        public static DataTable GetAll()
        {
            return ConnectionDAL.GetAll();
        }

        public static DataTable GetCommingRequests(Guid UserId)
        {
            return ConnectionDAL.GetCommingRequests( UserId);
        }

        public static DataTable GetSentRequests(Guid UserId)
        {
            return ConnectionDAL.GetSentRequests( UserId);
        }

        public static int AddnewConnection(Guid From, Guid To)
        {            
            return ConnectionDAL.AddnewConnection(From, To); ;
        }
        

        public static int ModifyConnectionAccepted(int ConnId)
        {
            return ConnectionDAL.ModifyConnectionAccepted( ConnId);
        }
        public static int ModifyConnectionAccepted(Guid fromId, Guid toId)
        {
            return ConnectionDAL.ModifyConnectionAccepted( fromId,  toId);
        }

        public static int ModifyConnectionRejected(int ConnId)
        {
            return ConnectionDAL.ModifyConnectionRejected( ConnId);
        }
        public static int ModifyConnectionRejected(Guid fromId, Guid toId)
        {
            return ConnectionDAL.ModifyConnectionRejected( fromId,  toId);
        }
        public static int DeleteReplicate()
        {
            return ConnectionDAL.DeleteReplicate();
        }
        public static int DeleteConnectionBetween(Guid id1, Guid id2)
        {
            return ConnectionDAL.DeleteConnectionBetween( id1,  id2);
        }
        public static int DeleteConnectionFromTo(Guid fromId, Guid toId)
        {
            return ConnectionDAL.DeleteConnectionFromTo( fromId,  toId);
        }
        public static int DeleteConnectionById(int connId)
        {
            return ConnectionDAL.DeleteConnectionById( connId);
        }
        public static DataTable GetAllTo(Guid UserId)
        {
            return ConnectionDAL.GetAllTo( UserId);
        }

        public static DataTable GetAllToAndWaiting(Guid UserId)
        {
            return ConnectionDAL.GetAllToAndWaiting( UserId);
        }

        public static DataTable GetAllFrom(Guid UserId)
        {
            return ConnectionDAL.GetAllFrom(UserId);
        }

        public static DataTable GetAllFromAndWaiting(Guid UserId)
        {
            return ConnectionDAL.GetAllFromAndWaiting( UserId);
        }

        public static bool CheckFromTo(Guid from, Guid to)
        {
            return ConnectionDAL.CheckFromTo( from,  to);
        }

        public static DataTable GetUserConnections(Guid UserId)
        {
            return ConnectionDAL.GetUserConnections(UserId);
        }

    }
}