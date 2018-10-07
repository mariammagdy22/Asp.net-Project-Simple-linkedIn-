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
    public partial class Ctrl_AddNewCountry : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            
            string countryName = txt_CountryName.Text;
            bool checkinserted = CountryBLL.CheckNameInserted(countryName);
            if (!checkinserted)
            {
                CountryBLL.InsertNewCountry(countryName);
            }

            if (Request.QueryString["Redirect"] == "AddUserCountry")
            {Response.Redirect($"~/Pages/User/AddUserCountry.aspx");}

            if (Request.QueryString["Redirect"] == "MyProfile")
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
                Guid UserId = (Guid)CurrentUser.ProviderUserKey;
                


                Response.Redirect($"~/Pages/User/MyProfile.aspx");
            }

            
        }
    }
}