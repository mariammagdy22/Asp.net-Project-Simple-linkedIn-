using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace LinkedIN.Controls.Admin
{
    public partial class ctrl_RulesAdd : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            Roles.CreateRole(txt_RuleName.Text);
            Response.Redirect("~/Pages/Admin/RolesList.aspx");
        }
    }
}