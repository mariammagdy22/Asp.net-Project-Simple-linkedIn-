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
    public partial class ctrl_EditLanguage : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser == null)
                {
                    Response.Redirect("~/Pages/User/Login.aspx");

                }
                else
                {
                   // Guid FK_UserId = (Guid)CurrentUser.ProviderUserKey;
                    DataTable dt = LanguageBLL.GetAlluserlang(); //(FK_UserId);
                    gv_editlang.DataSource = dt;
                    gv_editlang.DataKeyNames = new string[] { "LanguageId" };
                    gv_editlang.DataKeyNames = new string[] { "LanguageLevelName" };

                    gv_editlang.DataBind();
                    ViewState["language"] = dt;
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int FK_LanguageId = (int)gv_editlang.DataKeys[e.RowIndex].Values[0];   //.ToString(); 

       LanguageBLL.DeleteUserLanguage( FK_LanguageId);
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);


        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

           int FK_LanguageId = (int)gv_editlang.DataKeys[e.RowIndex].Values[0];
            //int FK_LanguageLevel = Convert.ToInt32(ddl_editprof.SelectedValue);
            int UserLanguageId = (int)gv_editlang.DataKeys[e.RowIndex].Values[0];

            int FK_LanguageLevel = (int)gv_editlang.DataKeys[e.RowIndex].Values[0];


            string LangId = gv_editlang.DataKeys[e.RowIndex].Values[0].ToString();
            DropDownList ddl_editproff = ((DropDownList)gv_editlang.Rows[e.RowIndex].FindControl("ddl_editprof"));
            TextBox txt_editnamelangg = ((TextBox)gv_editlang.Rows[e.RowIndex].FindControl("txt_editnamelang"));
            LanguageBLL.Updatelang(FK_LanguageId, FK_LanguageLevel, UserLanguageId);
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);

        }




        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

            gv_editlang.EditIndex = e.NewEditIndex;
            gv_editlang.DataSource = (DataTable)ViewState["language"];
            gv_editlang.DataBind();

            DropDownList ddl_editprof = ((DropDownList)gv_editlang.Rows[e.NewEditIndex].FindControl("ddl_editprof"));

            DataTable langdt = LanguageBLL.GetAllLevells();
            ddl_editprof.DataSource = langdt;
            ddl_editprof.DataTextField = "LanguageLevelName";
            ddl_editprof.DataValueField = "LanguageLevelId";
            ddl_editprof.DataBind();
            ddl_editprof.SelectedValue = ((DataTable)ViewState["language"]).Rows[e.NewEditIndex]["languageLevelId"].ToString();
        }






        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_editlang.EditIndex = -1;
            gv_editlang.DataSource = (DataTable)ViewState["language"];
            gv_editlang.DataBind();

        }
    }
}