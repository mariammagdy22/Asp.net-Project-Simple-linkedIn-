using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkedIN.Controls.CommonC
{
    public partial class ctrl_Footer1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ddl_theme.SelectedValue = Page.Theme.ToString();

            }
        }

        protected void lbtn_en_Us_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie;
            if (Request.Cookies["LinkedINPref"] != null)
            {
                myCookie = Request.Cookies["LinkedINPref"];
                myCookie["Language"] = "en-Us";
            }
            else
            {
                myCookie = new HttpCookie("LinkedINPref");
                myCookie["Language"] = "en-Us";
            }
            Response.Cookies.Add(myCookie);            
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
        }

        protected void lbtn_ar_Eg_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie;
            if (Request.Cookies["LinkedINPref"] != null)
            {
                myCookie = Request.Cookies["LinkedINPref"];
                myCookie["Language"] = "ar-Eg";
            }
            else
            {
                myCookie = new HttpCookie("LinkedINPref");
                myCookie["Language"] = "ar-Eg";
            }
            Response.Cookies.Add(myCookie);            
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
        }

        protected void ddl_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpCookie myCookie;
            myCookie = Request.Cookies["LinkedINPref"];
            myCookie["Theme"] = ddl_theme.SelectedValue.ToString();
            Response.Cookies.Add(myCookie);
            ViewState.Add("Theme", ddl_theme.SelectedValue.ToString());
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
        }
    }
}