using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMAWeb.Pages
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!Context.User.Identity.IsAuthenticated)
                {
                    System.Diagnostics.Trace.TraceWarning("[Admin.aspx] - Page_Load : L'utilisateur n'est pas authentifié; redirection vers la page de Login.");

                    FormsAuthentication.RedirectToLoginPage();
                    return;
                }

                //User.IsInRole: calls GetRolesForUser() method from default Role Provider once; then, store the roles in cookie (cacheRolesInCookie="true" attribute from web.config).
                if (!Context.User.IsInRole(RolesManager.Admin.ToString()))
                {
                    Response.Redirect("Index.aspx");

                    System.Diagnostics.Trace.TraceWarning("[Admin.aspx] - Page_Load : L'utilisateur n'est pas administrateur; redirection vers la page d'accueil.");
                }
            }
        }
    }
}