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
    public partial class ctrl_Message : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //MembershipUser CurrentUser = Membership.GetUser();
                //Guid UserId = (Guid)CurrentUser.ProviderUserKey;
                DataTable dt = MessageBLL.GetAllUsers();
                ddl_users.DataSource = dt;               
                ddl_users.DataTextField = "UserName";
                ddl_users.DataValueField = "UserId";
                ddl_users.DataBind();

                
                if (Request.QueryString["messaging"]!= null)
                {
                    Guid otherId = new Guid(Request.QueryString["messaging"]);
                    MembershipUser CurrentUser = Membership.GetUser();
                    Guid UserId = (Guid)CurrentUser.ProviderUserKey;
                    DataTable dtt = MessageBLL.GetAllMsgBw(UserId, otherId);
                    gv_message.DataSource = dtt;
                    gv_message.DataBind();
                }



            }

        }

        protected void gv_message_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_users_Click(object sender, EventArgs e)
        {

            MembershipUser CurrentUser = Membership.GetUser();
            Guid UserId = (Guid)CurrentUser.ProviderUserKey;
            Guid otherId = new Guid(ddl_users.SelectedValue);
            DataTable dtt = MessageBLL.GetAllMsgBw( UserId,  otherId);
            gv_message.DataSource = dtt;
            //gv_message.DataKeyNames = new string[] { "Fk_FromId", "FK_ToId" };
            gv_message.DataBind();
            
            //dtt.PrimaryKey = new DataColumn[] { dtt.Columns["MessageId"], dtt.Columns["FK_FromId"] };
            //ViewState["Message"] = dtt;
        }

        protected void txt_send_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_send_Click(object sender, EventArgs e)
        {
            string msg = txt_send.Text;
            
            MembershipUser CurrentUser = Membership.GetUser();
            Guid senderId = (Guid)CurrentUser.ProviderUserKey;
            Guid receiverId = new Guid(ddl_users.SelectedValue);
            string message = txt_send.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            MessageBLL.AddMsg(senderId, receiverId, message, date);
            Response.Redirect($"~/Pages/Users/Message.aspx?messaging={receiverId}");
        }
    }
}