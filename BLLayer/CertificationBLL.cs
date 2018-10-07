using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.BLLayer
{
    public class CertificationBLL
    {
        public static DataTable GetAll()
        {
            return CertificationDAL.GetAll();
        }

        public static DataTable GetByCertificateId (int CertificateId)
        {
            return CertificationDAL.GetByCertificateId (CertificateId);
        }
        public static DataTable GetByCertificateName(string CertificateName) 
        {
            return CertificationDAL.GetByCertificateName(CertificateName);
        }
        public static DataTable GetByFK_UserId(Guid FK_UserId)
        {
            return CertificationDAL.GetByFK_UserId(FK_UserId);

        }

        public static DataTable GetByFK_UserId_(Guid FK_UserId)
        {
            return CertificationDAL.GetByFK_UserId_(FK_UserId);

        }


        public static DataTable InsertCertNameDate(string CertificateName, string CertificateDate , Guid FK_UserId)
        {
            return CertificationDAL.InsertCertNameDate(CertificateName, CertificateDate, FK_UserId);
        }

        //public static DataTable InsertCertDate(string CertificateDate)
        //{
        //    return CertificationDAL.InsertCertDate( CertificateDate);
        //}


        public static DataTable deleteCertificateName(string CertificateName)
        {
            return CertificationDAL.deleteCertificateName(CertificateName);
        }


        public static DataTable deleteCertificate(int CertificateId)
        {
            return CertificationDAL.deleteCertificate(CertificateId);
        }

        public static int Updatecert(int CertificateId, string CertificateName, string CertificateDate)
        {
            return CertificationDAL.Updatecert(CertificateId, CertificateName, CertificateDate);
        }





        ////////////UserCertificates///////////

        //public static DataTable GetAllCert()
        //{
        //    return CertificationDAL.GetAllCert();
        //}
        //public static DataTable GetByCertId(int Id)
        //{
        //    return CertificationDAL.GetByCertId(Id);
        //}

        //public static DataTable GetByDateCert(int CertificateDate)
        //{
        //    return CertificationDAL.GetByDateCert( CertificateDate);
        //}

        //public static DataTable GetByFK_UserId(int FK_UserId)
        //{
        //    return CertificationDAL.GetByFK_UserId(FK_UserId);
        //}

        //private static int Remove(int FK_UserId)
        //{
        //    return CertificationDAL.Remove(FK_UserId);
        //}

        //public static int insertUserCertificates(Guid Fk_UserId, string FK_CertificateId)
        //{
        //    return CertificationDAL.insertUserCertificates(Fk_UserId, FK_CertificateId);

        //}
        //public static int DeleteUserCertificates(int FK_CertificateId)
        //{
        //    return CertificationDAL.DeleteUserCertificates(FK_CertificateId);

        //}




    }
}