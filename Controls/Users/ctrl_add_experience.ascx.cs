using LinkedIN.BLLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkedIN.Controls.Users
{
    public partial class ctrl_add_experience : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt2 = CountryBLL.GetAll();

                ddl_fill_country.DataTextField = "Name";
                ddl_fill_country.DataValueField = "CountryId";
                ddl_fill_country.DataBind();
                ddl_fill_country.DataSource = dt2;

                //    //DataTable dt1 = CourseBLL.GetAllCourseAssocWith();
                //    //ddl_associated_with.DataSource = dt1;
                //    //ddl_associated_with.DataTextField = "CourseAssociatedWith";
                //    //ddl_associated_with.DataValueField = "CourseId";
                //    //ddl_associated_with.DataBind();
                //} 
            }

        }

        protected void txt_exp_company_TextChanged(object sender, EventArgs e)
        {
        }

        protected void ddl_choose_company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_save__Click(object sender, EventArgs e)
        {

        }

        protected void ddl_choose_country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_save_exp_Click(object sender, EventArgs e)
        {
            // get login userId
            MembershipUser CurrentUser = Membership.GetUser();
            Guid FK_UserId = (Guid)CurrentUser.ProviderUserKey;
            // string FK_UserId = UserId.ToString();
            string Country = txt_exp_country.Text;
            string Company = txt_exp_company.Text;
            string StartingDate = txt_exp_startingdate.Text;
            string Title = txt_exp_title.Text;
            ExperienceBLL.InsertNewUserExperience(FK_UserId, Country, Company, Title, StartingDate);
            // CourseBLL.insertNewCourseToUser(UserId, txt_add_course.Text.ToString());
            // CourseBLL.insertNewCourse(CourseName, CourseNumber, CourseDate, CourseAssociatedWith);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}