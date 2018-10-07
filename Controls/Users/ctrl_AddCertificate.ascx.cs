using LinkedIN.BLLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkedIN.Controls.Users
{
    public partial class ctrl_AddCertificate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void btn_addcert_Click(object sender, EventArgs e)
        {
            string cn = txt_addcert.Text;
            string cd = txt_addcertdate.Text;
            MembershipUser CurrentUser = Membership.GetUser();
            Guid UserId = (Guid)CurrentUser.ProviderUserKey;

            CertificationBLL.InsertCertNameDate(cn,cd,UserId);

            lbl_data.Text = "Your Data is Saved";





        }
    }
}