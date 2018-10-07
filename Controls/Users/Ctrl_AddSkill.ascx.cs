using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LinkedIN.BLLayer;
using System.Data;
using System.Web.Security;

namespace LinkedIN.Controls.Users
{
    public partial class Ctrl_AddSkill : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt= SkillLevelBLL.GetAll();
                ddl_SkillLevel.DataSource = dt;
                ddl_SkillLevel.DataTextField = "SkillLevelName";
                ddl_SkillLevel.DataValueField = "SkillLevelId";
                ddl_SkillLevel.DataBind();
                lbl_message.Visible = false;
            }

        }

        protected void btn_addSkill_Click(object sender, EventArgs e)
        {
            MembershipUser CurrentUser = Membership.GetUser();
            if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
            Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
            string skillName = txt_SkillName.Text;
            string skillLevelId = ddl_SkillLevel.SelectedValue;
            int rAff = SkillBLL.Add(skillName, skillLevelId, UserId);
            if (rAff>0)
            {
                lbl_message.Text = "Skill Added Successfully";
                lbl_message.Visible = true;
            }
            if (Request.QueryString["Redirect"] == "MyProfile")
            {
                Response.Redirect($"~/Pages/User/MyProfile.aspx");
            }
            
        }
    }
}