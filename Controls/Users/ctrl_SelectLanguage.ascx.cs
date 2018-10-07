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
    public partial class SelectLanguage : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = LanguageBLL.GetAll();
                ddl_selectlang.DataSource = dt;
                ddl_selectlang.DataTextField = "LangName";
                ddl_selectlang.DataValueField = "LanguageId";
                ddl_selectlang.DataBind();

                DataTable dtt = LanguageBLL.GetAllLevells();
                ddl_prof.DataSource = dtt;
                ddl_prof.DataTextField = "LanguageLevelName";
                ddl_prof.DataValueField = "LanguageLevelId";
                ddl_prof.DataBind();

            }
        }
        //protected void  btn_select_Click(object sender, EventArgs e)
        //{
        //    MembershipUser CurrentUser = Membership.GetUser();
        //    Guid FK_UserId = (Guid)CurrentUser.ProviderUserKey;
        //   string FK_LanguageId = ddl_selectlang.SelectedValue;
        //    LanguageBLL.insertUserLanguage(FK_UserId , FK_LanguageId);
        //}

        protected void ddl_selectlang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddl_selectlang_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            MembershipUser CurrentUser = Membership.GetUser();
            Guid Fk_UserId = (Guid)CurrentUser.ProviderUserKey;
            string FK_LanguageLevel = ddl_prof.SelectedValue;
            string FK_LanguageId = ddl_prof.SelectedValue;
            

            LanguageBLL.InsertIdLevelUser(Fk_UserId, FK_LanguageLevel, FK_LanguageId);
        }

        protected void lbtn_add_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/Pages/Users/AddUserLanguage.aspx");
            Response.Redirect("~/Pages/User/Add Your Language.aspx");


        }
    }
}