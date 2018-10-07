using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.BLLayer
{
    public class EducationBLL
    {
        public static DataTable GetAll()
        {


            return EducationDAL.GetAll();
        }

        public static DataTable GetByEducationId(string Id)
        {




            return EducationDAL.GetByEducationId(Id);
        }
        public static DataTable GetByUserId(Guid Id)
        {




            return EducationDAL.GetByUserId(Id);
        }
        public static int InsertUserEducation(string SchoolName, string StartDate, string EndDate, string SchoolLocation, string specialization, Guid UserId)
        {


            return EducationDAL.InsertUserEducation( SchoolName,  StartDate, EndDate,  SchoolLocation,specialization,  UserId);

        }
        public static int Remove(int Id)
        {

            return EducationDAL.Remove(Id);
        }


        
    }
    }
