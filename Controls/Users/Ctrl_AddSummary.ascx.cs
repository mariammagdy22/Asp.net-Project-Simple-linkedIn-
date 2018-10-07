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
    public partial class Ctrl_AddSummary : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_Next_Click(object sender, EventArgs e)
        {
            MembershipUser CurrentUser = Membership.GetUser();
            if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
            Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
            string Summary = txt_Summary.Text;
            UserBLL.ModifyUserSummary(UserId, Summary);

            Response.Redirect($"~/Pages/User/UploadPhoto.aspx?Case=AddProfilePhoto");
            

        }
    }
}