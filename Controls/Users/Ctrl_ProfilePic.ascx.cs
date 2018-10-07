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
    public partial class Ctrl_ProfilePic : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] == null)
                {
                    Response.Redirect("~/Pages/User/ShowConnections.aspx");
                }
                else
                {
                    Guid profileId = new Guid(Request.QueryString["Id"]);
                    //MembershipUser CurrentUser = Membership.GetUser();
                    //if (CurrentUser == null) { Response.Redirect($"~/Pages/Users/Login.aspx"); }
                    //Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
                    DataTable dt = UserBLL.GetById(profileId);
                    gv_UserDetails.DataSource = dt;
                    //gv_UserDetails.DataKeyNames = new string[] { "ConnectionRequestId", "FK_UserFromId", "UserName" };
                    gv_UserDetails.DataBind();
                    //dt.PrimaryKey = new DataColumn[] { dt.Columns["ConnectionRequestId"], dt.Columns["FK_UserFromId"], dt.Columns["UserName"] };


                    //Get User Profile Pic
                    byte[] imagebytes = (byte[])PictureBLL.GetImageOnlyByUserId(profileId);
                    if (imagebytes!=null)
                    {
                        string strBase64 = Convert.ToBase64String(imagebytes);
                        img_ProfPic.ImageUrl = "data:Image/png;base64," + strBase64;

                    }
                }
            }

        }
    }
}