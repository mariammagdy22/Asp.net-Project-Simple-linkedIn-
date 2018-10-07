using LinkedIN.BLLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkedIN.Controls.Users
{
    public partial class ctrl_Projects : System.Web.UI.UserControl
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
                    //txt_ProjectName.Text = (string)ProjectBLL.GetProjectNameByUserID(userId);
                    //txt_StartDate.Text = (string)ProjectBLL.GetStartDate(userId);
                    //txt_EndDate.Text = (string)ProjectBLL.GetEndDate(userId);
                    //txt_Description.Text = (string)ProjectBLL.GetProjectDescription(userId);
                }
            }
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            MembershipUser CurrentUser = Membership.GetUser();
            Guid userId = (Guid)CurrentUser.ProviderUserKey;

            int added = ProjectBLL.AddProject(userId, txt_ProjectName.Text, txt_Description.Text, txt_StartDate.Text, txt_EndDate.Text);
            if(added > 0)
            {
                lbl_success.Text = "Your data has been added successfully ✔";
            }
            else
            {
                lbl_success.Text = "Error! Please check your data and try again";
            }
        }
    }
}