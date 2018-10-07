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
    public partial class Ctrl_AddUserCountry : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = CountryBLL.GetAll();
                ddl_selectCountry.DataSource = dt;
                ddl_selectCountry.DataTextField = "Name";
                ddl_selectCountry.DataValueField = "CountryId";
                ddl_selectCountry.DataBind();
            }
        }

        protected void btn_AddCountry_Click(object sender, EventArgs e)
        {            
            MembershipUser CurrentUser = Membership.GetUser();
            if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
            Guid UserId = (Guid)CurrentUser.ProviderUserKey;
            string CountryId = ddl_selectCountry.SelectedValue;
            int postalCode = Convert.ToInt32( txt_PostalCode.Text);
            UserBLL.InsertUserCountryAndPostalCode(UserId, postalCode, CountryId);

            Response.Redirect($"~/Pages/User/AddSummary.aspx");



        }

        protected void lbtn_AddNewCountry_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/Pages/Users/AddNewCountry.aspx?Redirect=AddUserCountry");
            //~Pages/Users/AddUserCountry.aspx


        }
    }
}