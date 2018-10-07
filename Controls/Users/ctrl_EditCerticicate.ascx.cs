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
    public partial class ctrl_EditCerticicate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                MembershipUser CurrentUser = Membership.GetUser();
                if(CurrentUser==null)
                {
                    Response.Redirect("~/Pages/User/Login.aspx");
                    
                }
                else
                {
                    Guid FK_UserId  = (Guid)CurrentUser.ProviderUserKey;
                    DataTable dt = CertificationBLL.GetByFK_UserId_(FK_UserId );
                    gv_editcert.DataSource = dt;
                    gv_editcert.DataKeyNames = new string[] { "CertificateId" };
                    gv_editcert.DataBind();
                    ViewState["Certificate"] = dt;
                }
            }
        }

        protected void gv_editcert_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int CertificateId = (int)gv_editcert.DataKeys[e.RowIndex].Values[0];
            CertificationBLL.deleteCertificate(CertificateId);
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
        }

        protected void gv_editcert_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int CertificateId = (int)gv_editcert.DataKeys[e.RowIndex].Values[0];

            //In the Edit-Template ///\\\///\\\
            TextBox CertificateName = ((TextBox)gv_editcert.Rows[e.RowIndex].FindControl("txt_name"));
            TextBox CertificateDate = ((TextBox)gv_editcert.Rows[e.RowIndex].FindControl("txt_date"));

            CertificationBLL.Updatecert(CertificateId, CertificateName.Text, CertificateDate.Text);

            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
        }

        protected void gv_editcert_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_editcert.EditIndex = e.NewEditIndex;
            gv_editcert.DataSource = (DataTable)ViewState["Certificate"];
            gv_editcert.DataBind();
        }

        protected void gv_editcert_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_editcert.EditIndex = -1;
            gv_editcert.DataSource = (DataTable)ViewState["Certificate"];
            gv_editcert.DataBind();
        }
    }
}