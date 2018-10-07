using LinkedIN.DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.BLLayer
{
    public class CourseBLL
    {
        public static DataTable GetAllCourse()
        {            
            return CourseDAL.GetAllCourse();
        }
        public static DataTable GetAllUserCourse()
        {
            return CourseDAL.GetAllUserCourse();
        }
        public static DataTable GetAllCourseAssocWith()
        {
            return CourseDAL.GetAllCourseAssocWith();
        }

        public static DataTable GetAllCourseById(int CourseId)
        {
            return CourseDAL.GetAllCourseById( CourseId);
        }
        public static DataTable GetAllUserCourseById(Guid UserId)
        {
            return CourseDAL.GetAllUserCourseById( UserId);
        }
        public static int InsertNewCourseToUser(Guid UserId, string CountryId)
        {
            return CourseDAL.InsertNewCourseToUser(UserId, CountryId);
        }
        public static int InsertNewCourse(string CourseName, int CourseNumber, string CourseDate, string CourseAssociatedWith)
        {
            return CourseDAL.InsertNewCourse(CourseName, CourseNumber, CourseDate, CourseAssociatedWith);
        }

    }
}