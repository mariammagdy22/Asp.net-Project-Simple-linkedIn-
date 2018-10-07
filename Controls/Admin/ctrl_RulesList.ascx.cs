using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


namespace LinkedIN.Controls.Admin
{
    public partial class ctrl_RulesList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] AppRoles = new string[] { };
                AppRoles = Roles.GetAllRoles();
                gv_Rules.DataSource = AppRoles;
                gv_Rules.DataBind();


            }
        }
    }
}