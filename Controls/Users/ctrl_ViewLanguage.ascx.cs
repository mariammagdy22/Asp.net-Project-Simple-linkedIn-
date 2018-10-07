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
    public partial class ctrl_ViewLanguage : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser == null)
                {
                    Response.Redirect("~/Pages/User/Login.aspx");

                }
                else
                {
                    Guid FK_UserId = (Guid)CurrentUser.ProviderUserKey;
                    DataTable dt = LanguageBLL.GetToView(FK_UserId);
                    gv_viewlang.DataSource = dt;
                    gv_viewlang.DataKeyNames = new string[] { "LangName" };
                    gv_viewlang.DataBind();
                    ViewState["languagee"] = dt;
                }
            }
        }
    }
}