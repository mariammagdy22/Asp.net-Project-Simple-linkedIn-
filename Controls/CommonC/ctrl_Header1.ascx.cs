using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkedIN.Controls.CommonC
{
    public partial class ctrl_Header1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbl_date.Text = DateTime.Now.ToShortDateString();
            }
            
        }
    }
}