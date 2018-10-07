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
    public partial class Awardsl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
              MembershipUser CurrentUser = Membership.GetUser();
            Guid UserId = (Guid)CurrentUser.ProviderUserKey;
            string AwardName = TextBox1.Text.ToString();
            string Date=TextBox3.Text.ToString();
            string Provider=TextBox2.Text.ToString();
            AwardBLL.insertUserAward(AwardName, Date, Provider, UserId);
        }
    }
}