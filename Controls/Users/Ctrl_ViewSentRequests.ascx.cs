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
    public partial class Ctrl_ViewSentRequests : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
                Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
                DataTable dt = ConnectionBLL.GetAllFromAndWaiting(UserId);
                gv_viewSentReq.DataSource = dt;
                gv_viewSentReq.DataKeyNames = new string[] { "ConnectionRequestId", "FK_UserToId", "UserName" };
                gv_viewSentReq.DataBind();
                dt.PrimaryKey = new DataColumn[] { dt.Columns["ConnectionRequestId"], dt.Columns["FK_UserToId"], dt.Columns["UserName"] };

            }

        }
    }
}