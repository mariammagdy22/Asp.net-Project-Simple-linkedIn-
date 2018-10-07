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
    public partial class Ctrl_viewUpdateSkill : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
                Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
                DataTable dt = SkillBLL.GetByUserID(UserId);
                gv_skills.DataSource = dt;
                gv_skills.DataKeyNames = new string[] { "SkillId", "SkillName" };
                gv_skills.DataBind();
                dt.PrimaryKey = new DataColumn[] { dt.Columns["SkillId"] };
                ViewState["SkillsDT"] = dt;
                lbl_skillName.Visible = false;
                

            }

        }

        protected void gv_skills_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_skills.EditIndex = -1;
            gv_skills.DataSource = (DataTable)ViewState["SkillsDT"];
            gv_skills.DataBind();

        }

        protected void gv_skills_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string SkillId = gv_skills.DataKeys[e.RowIndex].Values[0].ToString();

            //Delete from Database
            SkillBLL.Remove(SkillId);

            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
        }

        protected void gv_skills_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_skills.EditIndex = e.NewEditIndex;
            gv_skills.DataSource = (DataTable)ViewState["SkillsDT"];
            gv_skills.DataBind();

            DropDownList ddl_newSkillLvl = ((DropDownList)gv_skills.Rows[e.NewEditIndex].FindControl("ddl_newSkill"));

            DataTable skilldt = SkillLevelBLL.GetAll();
            ddl_newSkillLvl.DataSource = skilldt;
            ddl_newSkillLvl.DataTextField = "SkillLevelName";
            ddl_newSkillLvl.DataValueField = "SkillLevelId";
            ddl_newSkillLvl.DataBind();
            ddl_newSkillLvl.SelectedValue = ((DataTable)ViewState["SkillsDT"]).Rows[e.NewEditIndex]["SkillLevelId"].ToString();
            

        }

        protected void gv_skills_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string SkillId = gv_skills.DataKeys[e.RowIndex].Values[0].ToString();
            DropDownList ddl_newSkillLvl = ((DropDownList)gv_skills.Rows[e.RowIndex].FindControl("ddl_newSkill"));            
            TextBox txtSkillName = ((TextBox)gv_skills.Rows[e.RowIndex].FindControl("txt_newSkillName"));
            SkillBLL.Update(txtSkillName.Text, ddl_newSkillLvl.SelectedValue, SkillId);            
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);

        }

        protected void btn_AddNewSkill_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/User/AddSkill.aspx?Redirect=MyProfile");
        }

        protected void gv_skills_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            //gv_skills.DataSource = (DataTable)ViewState["SkillsDT"];
            //gv_skills.DataBind();
            string SkillId = gv_skills.DataKeys[e.NewSelectedIndex].Values[0].ToString();
            string SkillName = gv_skills.DataKeys[e.NewSelectedIndex].Values[1].ToString();
            //MembershipUser CurrentUser = Membership.GetUser();
            //if (CurrentUser == null) { Response.Redirect($"~/Pages/Users/Login.aspx"); }
            //Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
            DataTable dt = SkillBLL.GetSkillEndorsers(SkillId);
            gv_Endorsers.DataSource = dt;
            //gv_skills.DataKeyNames = new string[] { "SkillId", "SkillName" };
            gv_Endorsers.DataBind();
            lbl_skillName.Text = SkillName;
            lbl_skillName.Visible = true;

        }
    }
}