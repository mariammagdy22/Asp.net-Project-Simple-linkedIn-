using LinkedIN.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LinkedIN.DALayer
{
    public class CourseDAL
    {
        public static DataTable GetAllCourse()
        {
            DataTable dt = DBL.ExecuteQuery("select * from Course");
            return dt;
        }
        public static DataTable GetAllCourseAssocWith()
        {
            DataTable dt = DBL.ExecuteQuery("select CourseId,CourseAssociatedWith from Course");
            return dt;
        }
        public static DataTable GetAllUserCourse()
        {
            DataTable dt = DBL.ExecuteQuery("select Course.CourseName,aspnet_Users.UserId from UserCourse left join aspnet_Users on UserId = FK_UserId left join Course on CourseId =FK_CourseId  ");
            return dt;
        }
        public static DataTable GetAllCourseById(int CourseId)
        {

            DataTable dt = DBL.ExecuteQuery("select * from Course where Course.CourseId=" + CourseId);
            return dt;
        }
        public static DataTable GetAllUserCourseById(Guid UserId)
        {
            DataTable dt = DBL.ExecuteQuery("select Course.CourseName,aspnet_Users.UserId from UserCourse left join aspnet_Users on UserId = FK_UserId left join Course on CourseId =FK_CourseId  where UserId ="+UserId);
            return dt;
        }
        public static int InsertUserCourse(Guid UserId, int CourseId)
        {
            int rowsAffected = DBL.ExecuteDML("insert into UserCourse(Fk_UserId, FK_CourseId) values ('" + UserId + "', " + CourseId + ")");
            return rowsAffected;
        }
        public static int InsertNewCourse(string CourseName, int CourseNumber, string CourseDate, string CourseAssociatedWith)
        {
            int rowsAffected = DBL.ExecuteDML("insert into Course(CourseName, CourseNumber, CourseDate, CourseAssociatedWith) values('" + CourseName + "', " + CourseNumber + ",' " + CourseDate + "', '" + CourseAssociatedWith + "')");
            return rowsAffected;
        }
        public static int InsertNewCourseToUser(Guid UserId ,string CourseName)
        {
            int rowsAffected = DBL.ExecuteDML("begin transaction declare @dataId int insert into Course(CourseName)" +
                " values ('"+CourseName+"') select @dataId=@@IDENTITY insert into UserCourse(FK_CourseId,FK_UserId)" +
                " values( @dataId  ,'"+ UserId+"')commit transaction ");
            return rowsAffected;
        }
        

        public static int RemoveCourse(int CourseId)
        {
            int rowsAffected = DBL.ExecuteDML("delete from Course where CourseId=" + CourseId);
            return rowsAffected;
        }
        public static int RemoveUserCourse(int CourseId)
        {
            int rowsAffected = DBL.ExecuteDML("delete from Course where CourseId=" + CourseId);
            return rowsAffected;
            /*delete from Course where Course.CourseId in(    select Course.CourseId from Course   inner join UserCourse   on UserCourse.FK_CourseId = Course.CourseId   inner join aspnet_Users   on aspnet_Users.UserId = UserCourse.FK_UserId   where aspnet_Users.UserId = 'e75b92f7-bc27-402d-8976-2eba1fbef4bb')*/
        }
        // delete ??

        public static int UpdateCourse(int CourseId,string CourseName, string CourseDate)
        {
            int rowsAffected = DBL.ExecuteDML("update Course set CourseName='"+ CourseName + "' , CourseDate='"+ CourseDate + "' where CourseId="+ CourseId+"");
            return rowsAffected;
        }
        public static int UpdateUserCourse(int CourseId, string CourseName, string CourseDate)
        {
            int rowsAffected = DBL.ExecuteDML("update Course set CourseName='" + CourseName + "' , CourseDate='" + CourseDate + "' where CourseId=" + CourseId+"");
            return rowsAffected;
        }
        // ?? 

        //public static int insertUserCountry(string UserId, int CountryId)
        //{
        //    int rowsAffected = DBL.ExecuteDML("insert into UserFull (Fk_UserId, FK_CountryId) values ('" + UserId + "', " + CountryId + ")");
        //    return rowsAffected;
        //}
      

    }
}