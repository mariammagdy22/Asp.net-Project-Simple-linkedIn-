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
    public partial class VolunteerExperience : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser == null)
                {
                    Response.Redirect("~/Pages/Users/Login.aspx");
                }
                else
                {
                    Guid userId = (Guid)CurrentUser.ProviderUserKey;
                    //txt_WorkName.Text = (string)VolExpBLL.GetWorkName(userId);
                    //txt_Role.Text = (string)VolExpBLL.GetWorkRole(userId);
                    //txt_description.Text = (string)VolExpBLL.GetWorkDescription(userId);
                }
            }
        }


        protected void btn_addVol_Click(object sender, EventArgs e)
        {
            MembershipUser CurrentUser = Membership.GetUser();
            Guid userId = (Guid)CurrentUser.ProviderUserKey;

            int added = VolExpBLL.AddAll(userId, txt_WorkName.Text, txt_description.Text, txt_Role.Text);
            if (added > 0)
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