using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class CertificationDAL
    {
        public static DataTable GetAll()
        {
            DataTable dt = DBL.ExecuteQuery("select * from Certificate");
            return dt;
        }

        public static DataTable GetByCertificateId (int CertificateId)
        {

            DataTable dt = DBL.ExecuteQuery("select * from Certificate where Certificate.CertificateId = " + CertificateId);
            return dt;
        }
        public static DataTable GetByCertificateName  (string CertificateName )
        {

            DataTable dt = DBL.ExecuteQuery("select * from Certificate where Certificate.CertificateName = " + CertificateName);
            return dt;
        }

        public static DataTable GetByFK_UserId(Guid FK_UserId)
        {

            DataTable dt = DBL.ExecuteQuery("select UserId,CertificateId,CertificateName,CONVERT(Date,CertificateDate) AS Date  from aspnet_Users join Certificate on aspnet_Users.UserId =Certificate.FK_UserId= " + FK_UserId);
            return dt;
        }
        public static DataTable GetByFK_UserId_(Guid FK_UserId)
        {

            DataTable dt = DBL.ExecuteQuery($"select * from  Certificate where FK_UserId= '{FK_UserId}'");
            return dt;
        }



        public static DataTable InsertCertNameDate (string CertificateName , string CertificateDate,Guid FK_UserId)
        {
            
            string sss = $"insert into Certificate(CertificateName , CertificateDate,FK_UserId) values('{CertificateName}', '{ CertificateDate }','{ FK_UserId }' )";
            DataTable dt = DBL.ExecuteQuery(sss);

            return dt;
        }

        public static DataTable deleteCertificateName(string CertificateName )
        {
            DataTable dt = DBL.ExecuteQuery("delete  Certificate where CertificateName= " + CertificateName);
            return dt;
        }

        public static DataTable deleteCertificate(int CertificateId)
        {
            DataTable dt = DBL.ExecuteQuery("delete  Certificate where CertificateId= " + CertificateId);
            return dt;
        }

        public static int Updatecert(int CertificateId, string CertificateName, string CertificateDate)
        {
            int rowsAffected = DBL.ExecuteDML($"update Certificate set CertificateName = '{CertificateName}' , CertificateDate = '{CertificateDate}' where CertificateId = '{CertificateId}' ");
            return rowsAffected;
        }




        //////////UserCertificates/////////////

        //public static DataTable GetAllCert() 
        //{
        //    DataTable dt = DBL.ExecuteQuery("select FK_UserId,FK_CertificateId,CertificateName  from aspnet_Users join UserCertificates on aspnet_Users.UserId = UserCertificates.FK_UserIdjoin Certificate on Certificate.CertificateId = UserCertificates.UserCertificatesId order by UserCertificates.UserCertificatesId");
        //    return dt;
        //}

        //internal static int Remove(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public static DataTable GetByCertId(int UserCertificatesId )
        //{

        //    DataTable dt = DBL.ExecuteQuery("select FK_CertificateId,CertificateName  from aspnet_Users join UserCertificates on aspnet_Users.UserId = UserCertificates.FK_UserId join Certificate on Certificate.CertificateId = UserCertificates.UserCertificatesId order by UserCertificates.UserCertificatesId = '" + UserCertificatesId + "'");
        //    return dt;
        //}

        //public static DataTable GetByDateCert(int CertificateDate )
        //{
        //    DataTable dt = DBL.ExecuteQuery("select CONVERT(Date, CertificateDate) AS Date from Certificate =" + CertificateDate);
        //    return dt;
        //}


        //public static DataTable GetByFK_UserId(int FK_UserId)
        //{

        //    DataTable dt = DBL.ExecuteQuery("select FK_CertificateId,CertificateName,CONVERT(Date,CertificateDate) AS Date  from aspnet_Users join UserCertificates on aspnet_Users.UserId = UserCertificates.FK_UserId join Certificate on Certificate.CertificateId = UserCertificates.UserCertificatesId order by UserCertificates.FK_UserId = " + FK_UserId);
        //    return dt;
        //}



        //public static int insertUserCertificates(Guid Fk_UserId, string FK_CertificateId)
        //{
        //    int rowsAffected = DBL.ExecuteDML("insert into UserCertificates (Fk_UserId, FK_CertificateId) values ('" + Fk_UserId + "', " + FK_CertificateId + ")");
        //    return rowsAffected;
        //}

        //public static int DeleteUserCertificates(int FK_CertificateId)
        //{
        //    int rowsAffected = DBL.ExecuteDML("delete UserCertificates where UserCertificates.FK_CertificateId=" + FK_CertificateId);
        //    return rowsAffected;
        //}
    }
}