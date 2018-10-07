using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkedIN.Pages.CommonP
{
    public class BasePage : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            //// here write the code to get the theme
            if (!IsPostBack)
            {
                HttpCookie myCookie;
                if (Request.Cookies["LinkedINPref"] != null)
                {
                    myCookie = Request.Cookies["LinkedINPref"];
                    if (myCookie["Theme"] == null)
                    {
                        myCookie["Theme"] = "Theme1";
                        Response.Cookies.Add(myCookie);
                    }

                }
                else
                {
                    myCookie = new HttpCookie("LinkedINPref");
                    myCookie["Theme"] = "Theme1";
                    Response.Cookies.Add(myCookie);
                }
                Page.Theme = myCookie["Theme"];


                // setting the language
                HttpCookie myCookie2;
                if (Request.Cookies["LinkedINPref"] != null)
                {
                    myCookie2 = Request.Cookies["LinkedINPref"];
                    if (myCookie2["Language"] == null)
                    {
                        myCookie2["Language"] = "en-Us";
                        Response.Cookies.Add(myCookie2);
                    }

                }
                else
                {
                    myCookie2 = new HttpCookie("LinkedINPref");
                    myCookie2["Language"] = "en-Us";
                    Response.Cookies.Add(myCookie2);
                }
                Page.Culture = myCookie2["Language"];
                Page.UICulture = myCookie2["Language"];


            }
            else
            {
                HttpCookie myCookie = Request.Cookies["LinkedINPref"];
                Page.Theme = myCookie["Theme"];
                Page.Culture = myCookie["Language"];
                Page.UICulture = myCookie["Language"];
            }


        }

    }
}