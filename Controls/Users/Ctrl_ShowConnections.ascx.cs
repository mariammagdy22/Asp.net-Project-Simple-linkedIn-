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
    public partial class Ctrl_ShowConnections : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
                Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
                DataTable dt = ConnectionBLL.GetUserConnections(UserId);
                gv_ShowConnections.DataSource = dt;
                gv_ShowConnections.DataKeyNames = new string[] { "friendId" };
                gv_ShowConnections.DataBind();
                //dt.PrimaryKey = new DataColumn[] { dt.Columns["friendId"] };

            }
        }

        protected void gv_ShowConnections_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Guid theOtherId = (Guid)(gv_ShowConnections.DataKeys[e.NewSelectedIndex].Values[0]);
            Response.Redirect($"~/Pages/User/UserProfile.aspx?Id={theOtherId}");
        }

        protected void gv_ShowConnections_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Guid theOtherId = (Guid)(gv_ShowConnections.DataKeys[e.RowIndex].Values[0]);
            Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
            ConnectionBLL.DeleteConnectionBetween(UserId, theOtherId);
            Response.Redirect("~/Pages/User/Connections.aspx");
        }
    }
}