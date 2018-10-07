using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace LinkedIN.Controls.Admin
{
    public partial class ctrl_RulesAndUsers : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipUserCollection muc = new MembershipUserCollection();
                muc = Membership.GetAllUsers();
                gv_RolesAndUsers.DataSource = muc;
                gv_RolesAndUsers.DataKeyNames = new string[] { "username" };
                gv_RolesAndUsers.DataBind();


                string[] AppRoles = new string[] { };
                AppRoles = Roles.GetAllRoles();
                cbl_Roles.DataSource = AppRoles;
                cbl_Roles.DataBind();
            }
        }


       


        protected void gv_RolesAndUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cbl_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewState["UserName"] != null)
            {

                foreach (ListItem chbx in cbl_Roles.Items)
                {
                    if (chbx.Selected)
                    {
                        if (!Roles.IsUserInRole(ViewState["UserName"].ToString(), chbx.Text))
                        {
                            Roles.AddUserToRole(ViewState["UserName"].ToString(), chbx.Text);
                        }
                    }
                    else if (!chbx.Selected)
                    {
                        if (Roles.IsUserInRole(ViewState["UserName"].ToString(), chbx.Text))
                        {
                            Roles.RemoveUserFromRole(ViewState["UserName"].ToString(), chbx.Text);
                        }
                    }


                }

            }

        }

        protected void gv_RolesAndUsers_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string username = gv_RolesAndUsers.DataKeys[e.NewSelectedIndex].Values[0].ToString();
            lbl_Roles.Text = username;
            ViewState["UserName"] = username;

            foreach (ListItem chbx in cbl_Roles.Items)
            {
                if (Roles.IsUserInRole(ViewState["UserName"].ToString(), chbx.Text))
                {
                    chbx.Selected = true;
                }
                else
                {
                    chbx.Selected = false;
                }
            }
        }

        
    }
}