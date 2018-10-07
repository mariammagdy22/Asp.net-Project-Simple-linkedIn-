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
    public partial class EditVolExp : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser == null)
                {
                    Response.Redirect("~/Pages/Users/Login.aspx");
                }
                else
                {
                    Guid userId = (Guid)CurrentUser.ProviderUserKey;
                    DataTable dt = VolExpBLL.GetByUserID(userId);
                    gv_VolExp.DataSource = dt;
                    gv_VolExp.DataKeyNames = new string[] { "VolExperienceId" };
                    gv_VolExp.DataBind();
                    ViewState["VolExpDT"] = dt;

                }
            }
        }

        protected void gv_VolExp_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_VolExp.EditIndex = -1;
            gv_VolExp.DataSource = (DataTable)ViewState["VolExpDT"];
            gv_VolExp.DataBind();
        }

        protected void gv_VolExp_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int VolExpID = (int)gv_VolExp.DataKeys[e.RowIndex].Values[0];
            VolExpBLL.DeleteByWorkId(VolExpID);
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);

        }

        protected void gv_VolExp_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_VolExp.EditIndex = e.NewEditIndex;
            gv_VolExp.DataSource = (DataTable)ViewState["VolExpDT"];
            gv_VolExp.DataBind();
        }

        protected void gv_VolExp_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int VolExpID = (int)gv_VolExp.DataKeys[e.RowIndex].Values[0];


            //In the Edit-Template ///\\\///\\\
            TextBox OrganizationName = ((TextBox)gv_VolExp.Rows[e.RowIndex].FindControl("txt_organization"));
            TextBox Role = ((TextBox)gv_VolExp.Rows[e.RowIndex].FindControl("txt_Role"));
            TextBox Description = ((TextBox)gv_VolExp.Rows[e.RowIndex].FindControl("txt_description"));
            VolExpBLL.Update(VolExpID, OrganizationName.Text, Description.Text, Role.Text);

            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);

        }
    }
}