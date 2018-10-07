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
    public partial class ctrl_Project : System.Web.UI.UserControl
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
                    DataTable dt = ProjectBLL.GetAllByUserID(userId);
                    gv_Projects.DataSource = dt;
                    gv_Projects.DataKeyNames = new string[] { "ProjectId" };
                    gv_Projects.DataBind();
                    ViewState["ProjectDT"] = dt;

                }
            }
        }

        protected void gv_Projects_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_Projects.EditIndex = -1;
            gv_Projects.DataSource = (DataTable)ViewState["ProjectDT"];
            gv_Projects.DataBind();
        }

        protected void gv_Projects_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ProjectID = (int)gv_Projects.DataKeys[e.RowIndex].Values[0];
            ProjectBLL.Delete(ProjectID);
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
        }

        protected void gv_Projects_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_Projects.EditIndex = e.NewEditIndex;
            gv_Projects.DataSource = (DataTable)ViewState["ProjectDT"];
            gv_Projects.DataBind();
        }

        protected void gv_Projects_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int projectId = (int)gv_Projects.DataKeys[e.RowIndex].Values[0];


            //In the Edit-Template ///\\\///\\\
            TextBox ProjectName = ((TextBox)gv_Projects.Rows[e.RowIndex].FindControl("txt_ProjectName"));
            TextBox StartDate = ((TextBox)gv_Projects.Rows[e.RowIndex].FindControl("txt_StartDate"));
            TextBox EndDate = ((TextBox)gv_Projects.Rows[e.RowIndex].FindControl("txt_EndDate"));
            TextBox Description = ((TextBox)gv_Projects.Rows[e.RowIndex].FindControl("txt_Description"));
            ProjectBLL.Update(projectId, ProjectName.Text, StartDate.Text, EndDate.Text, Description.Text);

            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
        }
    }
}