using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMAWeb
{
    public partial class PMAWeb : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Context.User.Identity.IsAuthenticated)
                {
                    //Connection successfull.
                    UserName.Text = Context.User.Identity.Name;

                    //User.IsInRole: calls GetRolesForUser() method from default Role Provider once; then, store the roles in cookie (cacheRolesInCookie attribute from web.config).
                    if (Context.User.IsInRole(RolesManager.Admin.ToString()))
                    {
                        //RoleMessage.Text = "Est Administrateur : ";
                        AdminPanel.Visible = true;
                    }
                    else
                    {
                        //Read role from cookie.
                        if (Context.User.IsInRole(RolesManager.TeamMember.ToString()))
                        {
                            //RoleMessage.Text = "Est Profil Magasin";
                            AdminPanel.Visible = false;
                        }
                        else
                        {
                            //Read role from cookie.
                            if (Context.User.IsInRole(RolesManager.Unknown.ToString()))
                            {
                                //    RoleMessage.Text = "Privilèges Insuffisants";
                                AdminPanel.Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    FormsAuthentication.RedirectToLoginPage();
                }
            }
        }

        protected void HLDisconnect_Click(object sender, EventArgs e)
        {
            if (Context.User.Identity.IsAuthenticated)
                FormsAuthentication.SignOut();

            FormsAuthentication.RedirectToLoginPage();
        }
    }
}