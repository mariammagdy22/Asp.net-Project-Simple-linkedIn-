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
    public partial class Ctrl_SendRequest : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser==null){Response.Redirect($"~/Pages/Common/MainLogin.aspx");}
                Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
                DataTable dt = UserBLL.GetPeopleYouMayKnow(UserId);
                gv_Users.DataSource = dt;
                gv_Users.DataKeyNames = new string[] { "UserId" , "UserName" };
                gv_Users.DataBind();
                dt.PrimaryKey = new DataColumn[] { dt.Columns["UserId"] ,dt.Columns["UserName"] };
                lbl_requestSent.Visible = false;
            }

        }

        protected void gv_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void gv_Users_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Guid theOtherId = (Guid)(gv_Users.DataKeys[e.NewSelectedIndex].Values[0]);
            MembershipUser CurrentUser = Membership.GetUser();
            if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
            Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
            bool checkSent = ConnectionBLL.CheckFromTo(UserId, theOtherId);
            bool checkReceived = ConnectionBLL.CheckFromTo(theOtherId, UserId);
                      

            if (checkSent)
            {
                lbl_requestSent.Text = $"a connection Request has been already Sent ";
                lbl_requestSent.Visible = true;
            }
            else if (checkReceived)
            {
                ConnectionBLL.ModifyConnectionAccepted(theOtherId, UserId);
                string name = gv_Users.DataKeys[e.NewSelectedIndex].Values[1].ToString();
                lbl_requestSent.Text = $"{name} has sent you a Request you are now connected ";
                lbl_requestSent.Visible = true;
            }
            else
            {
                ConnectionBLL.AddnewConnection(UserId, theOtherId);
                string name = gv_Users.DataKeys[e.NewSelectedIndex].Values[1].ToString();
                lbl_requestSent.Text = $"connection Request Sent To {name}";
                lbl_requestSent.Visible = true;
            }
            ConnectionBLL.DeleteReplicate();
            Response.Redirect("~/Pages/User/Connections.aspx");

        }
    }
}