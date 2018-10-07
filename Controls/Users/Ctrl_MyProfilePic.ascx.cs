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
    public partial class Ctrl_MyProfilePic : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
                Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
                DataTable dt = UserBLL.GetById(UserId);
                gv_UserDetails.DataSource = dt;
                gv_UserDetails.DataKeyNames = new string[] { "UserId" };
                gv_UserDetails.DataBind();
                //
                //dt.PrimaryKey = new DataColumn[] { dt.Columns["UserId"] };
                ViewState["UserDataDT"] = dt;

                //Get User Profile Pic
                byte[] imagebytes = (byte[])PictureBLL.GetImageOnlyByUserId(UserId);
                if (imagebytes != null)
                {
                    string strBase64 = Convert.ToBase64String(imagebytes);
                    img_ProfPic.ImageUrl = "data:Image/png;base64," + strBase64;

                }                
            }
        }

        protected void gv_UserDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_UserDetails.EditIndex = -1;
            gv_UserDetails.DataSource = (DataTable)ViewState["UserDataDT"];
            gv_UserDetails.DataBind();


        }

        protected void gv_UserDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gv_UserDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            MembershipUser CurrentUser = Membership.GetUser();
            if (CurrentUser == null) { Response.Redirect($"~/Pages/Common/MainLogin.aspx"); }
            Guid UserId = (Guid)((Membership.GetUser()).ProviderUserKey);
            TextBox txtPostalCode = ((TextBox)gv_UserDetails.Rows[e.RowIndex].FindControl("txt_PostalCode"));
            string PostalCode=txtPostalCode.Text;
            DropDownList ddl_country = ((DropDownList)gv_UserDetails.Rows[e.RowIndex].FindControl("ddl_Country"));
            string FK_CountryId = ddl_country.SelectedValue;
            TextBox txtSummary = ((TextBox)gv_UserDetails.Rows[e.RowIndex].FindControl("txt_Summary"));
            string Summary = txtSummary.Text;       
            UserBLL.ModifyUserfullData(UserId,  PostalCode,  FK_CountryId, Summary);
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);

        }

        protected void gv_UserDetails_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void gv_UserDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_UserDetails.EditIndex = e.NewEditIndex;
            gv_UserDetails.DataSource = (DataTable)ViewState["UserDataDT"];
            gv_UserDetails.DataBind();

            DropDownList ddl_Country = ((DropDownList)gv_UserDetails.Rows[e.NewEditIndex].FindControl("ddl_Country"));

            DataTable Countrydt = CountryBLL.GetAll();
            ddl_Country.DataSource = Countrydt;
            ddl_Country.DataTextField = "Name";
            ddl_Country.DataValueField = "CountryId";
            ddl_Country.DataBind();
            string ddlSelectedValue =((DataTable) ViewState["UserDataDT"]).Rows[e.NewEditIndex]["FK_CountryId"].ToString();
            if (ddlSelectedValue != null) { ddl_Country.SelectedValue = ddlSelectedValue; }

        }

        protected void lbtn_ChangeProfilePhoto_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/Pages/User/UploadPhoto.aspx?Case=AddProfilePhoto");
        }

        protected void lbtn_addNewCountry_Click(object sender, EventArgs e)
        {
            Response.Redirect($"~/Pages/User/AddNewCountry.aspx?Redirect=MyProfile");
            
        }
    }
}