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
    public partial class Ctrl_Profileskills : System.Web.UI.UserControl
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
                    MembershipUser CurrentUser = Membership.GetUser();
                    if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
                    Guid VisitorId = (Guid)((Membership.GetUser()).ProviderUserKey);
                    DataTable dt = SkillBLL.GetByUserID(profileId);
                    gv_Skills.DataSource = dt;
                    gv_Skills.DataKeyNames = new string[] { "SkillId" };
                    gv_Skills.DataBind();
                    dt.PrimaryKey = new DataColumn[] { dt.Columns["SkillId"] };
                    lbl_Discription.Visible = false;



                }
            }

        }

        protected void gv_Skills_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string SkillId = gv_Skills.DataKeys[e.NewSelectedIndex].Values[0].ToString();
            Guid profileId = new Guid(Request.QueryString["Id"]);
            MembershipUser CurrentUser = Membership.GetUser();
            if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
            Guid VisitorId = (Guid)((Membership.GetUser()).ProviderUserKey);
            bool endorsed = EndorsementBLL.CheckEndorsement(SkillId, VisitorId, profileId);
            bool samePerson = String.Equals(VisitorId, profileId);
            if (samePerson)
            {
                lbl_Discription.Text = "User Can`t Endorse himself";
                lbl_Discription.Visible = true;
            }
            else if (endorsed)
            {
                SkillBLL.De_Endorse(SkillId);
                EndorsementBLL.RemovebyParams(SkillId, VisitorId, profileId);
                Response.Redirect($"~/Pages/User/UserProfile.aspx?Id={profileId}");
            }
            else
            {
                SkillBLL.Endorse(SkillId);
                EndorsementBLL.Add(SkillId, VisitorId, profileId);
                Response.Redirect($"~/Pages/User/UserProfile.aspx?Id={profileId}");
            }
            
        }
    }
}