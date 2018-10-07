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
    public partial class ctrl_Education : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            MembershipUser CurrentUser = Membership.GetUser();
            Guid UserId = (Guid)CurrentUser.ProviderUserKey;
            string SchoolName = TextBox1.Text.ToString();
            string SchoolLocation = TextBox3.Text.ToString();
            string FieldOfStudy = TextBox2.Text.ToString();
            string From = TextBox4.Text.ToString();
            string To = TextBox5.Text.ToString();
            EducationBLL.InsertUserEducation(SchoolName, From, To, SchoolLocation, FieldOfStudy, UserId);
        }
    }
}