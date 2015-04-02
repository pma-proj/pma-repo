using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMAWeb.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.User.Identity.IsAuthenticated)
            {
                System.Diagnostics.Trace.TraceWarning("[Index.aspx] - Page_Load : L'utilisateur n'est pas authentifié; redirection vers la page de Login.");

                FormsAuthentication.RedirectToLoginPage();
                return;
            }
        }
    }
}