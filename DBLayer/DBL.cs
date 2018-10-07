using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LinkedIN.DBLayer
{
    public class DBL
    {
        static string conStr;
        //public static string ConStr { get => conStr; }
        static DBL()
        {
            conStr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
        }
        public static DataTable ExecuteQuery(string SelectStatement)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(SelectStatement, con);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            return dt;
        }
        public static int ExecuteDML(string DMLStatement)
        {
            int rowsAffected = 0;
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(DMLStatement, con);
            con.Open();
            rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
        public static int AddImage(string procName,string fileName, int fileSize, byte[] bytes,Guid UserId)
        {
            object result;
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paramName = new SqlParameter()
            {
                ParameterName = "@Name",
                Value = fileName
            };
            cmd.Parameters.Add(paramName);

            SqlParameter paramSize = new SqlParameter()
            {
                ParameterName = "@Size",
                Value = fileSize
            };
            cmd.Parameters.Add(paramSize);

            SqlParameter paramImageData = new SqlParameter()
            {
                ParameterName = "@ImageData",
                Value = bytes
            };
            cmd.Parameters.Add(paramImageData);

            SqlParameter paramUserId = new SqlParameter()
            {
                ParameterName = "@FK_UserIdAddedBy",
                Value = UserId
            };
            cmd.Parameters.Add(paramUserId);

            SqlParameter paramNewId = new SqlParameter()
            {
                ParameterName = "@NewId",
                Value = -1,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(paramNewId);



            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return Convert.ToInt32(cmd.Parameters["@NewId"].Value);
        }
        public static object ExecuteScalar(string SelectOneCellQuery)
        {
            object result;
            SqlConnection sqlCon = new SqlConnection(conStr);
            SqlCommand SqlCom = new SqlCommand(SelectOneCellQuery, sqlCon);
            sqlCon.Open();
            result = SqlCom.ExecuteScalar();
            sqlCon.Close();
            return result;
        }

    }
}