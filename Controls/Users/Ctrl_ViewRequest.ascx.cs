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
    public partial class Ctrl_ViewRequest : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
                Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
                DataTable dt = ConnectionBLL.GetAllToAndWaiting(UserId);
                gv_viewRequest.DataSource = dt;
                gv_viewRequest.DataKeyNames = new string[] { "ConnectionRequestId", "FK_UserFromId", "UserName" };
                gv_viewRequest.DataBind();
                dt.PrimaryKey = new DataColumn[] { dt.Columns["ConnectionRequestId"], dt.Columns["FK_UserFromId"], dt.Columns["UserName"] };

            }
        }

        protected void gv_viewRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        protected void gv_viewRequest_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int connId = Convert.ToInt32(gv_viewRequest.DataKeys[e.RowIndex].Values[0]);
            ConnectionBLL.ModifyConnectionRejected(connId);
            ConnectionBLL.DeleteConnectionById(connId);

            Response.Redirect("~/Pages/User/Connections.aspx");

        }
        protected void gv_viewRequest_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int connId = Convert.ToInt32(gv_viewRequest.DataKeys[e.NewSelectedIndex].Values[0]);
            ConnectionBLL.ModifyConnectionAccepted(connId);

            Response.Redirect("~/Pages/User/Connections.aspx");

        }
    }
}