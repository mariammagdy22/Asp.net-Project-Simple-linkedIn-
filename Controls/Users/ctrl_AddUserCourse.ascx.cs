using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LinkedIN.BLLayer;
using System.Data;
using System.Web.Security;

namespace LinkedIN.Controls.Users
{
    public partial class Ctrl_AddUserCourse : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = CourseBLL.GetAllCourse();
                ddl_choose_course.DataSource = dt;
                ddl_choose_course.DataTextField = "CourseName";
                ddl_choose_course.DataValueField = "CourseId";
                ddl_choose_course.DataBind();

                //DataTable dt1 = CourseBLL.GetAllCourseAssocWith();
                //ddl_associated_with.DataSource = dt1;
                //ddl_associated_with.DataTextField = "CourseAssociatedWith";
                //ddl_associated_with.DataValueField = "CourseId";
                //ddl_associated_with.DataBind();

            } 
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_add_course_Click(object sender, EventArgs e)
        {
            
        }

        protected void ddl_associated_with_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txt_add_associated_with_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_save_course_Click(object sender, EventArgs e)
        {
            // two lines to get logged user id 
            MembershipUser CurrentUser = Membership.GetUser();
            Guid UserId = (Guid)CurrentUser.ProviderUserKey;
            // define of varibles needed to function calling
            string CourseId = ddl_choose_course.SelectedValue;// transaction
            string CourseName = txt_add_course.Text.ToString();
            int CourseNumber = Convert.ToInt32( txt_course_number.Text);
            string CourseDate = txt_course_date.Text.ToString();
            string CourseAssociatedWith = txt_add_associated_with.Text;
            // calling function with defined variables
            CourseBLL.InsertNewCourseToUser(UserId, txt_add_course.Text.ToString());//transaction.
            CourseBLL.InsertNewCourse(CourseName, CourseNumber, CourseDate, CourseAssociatedWith);
        }
    }
}