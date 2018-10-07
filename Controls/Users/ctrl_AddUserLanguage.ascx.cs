using LinkedIN.BLLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkedIN.Controls.Users
{
    public partial class Ctrl_AddUserLanguage : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataTable dtt = LanguageBLL.GetAllLevells();
            //ddl_profi.DataSource = dtt;
            //ddl_profi.DataTextField = "LanguageLevelName";
            //ddl_profi.DataValueField = "LanguageLevelId";
            //ddl_profi.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e) 
        {
            
            string sss= txt_language.Text;

            LanguageBLL.InsertLang (sss);
            //redirect on select languague;
            //lbl_select.Text = "Select your Language ";
            Response.Redirect("~/Pages/User/Language.aspx");


        }
        protected void txt_language_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txt_language_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddl_profi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}