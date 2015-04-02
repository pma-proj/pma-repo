using PMAWeb.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PMAWeb.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Context.User.Identity.IsAuthenticated)
                {
                    System.Diagnostics.Trace.TraceWarning("[Login.aspx] - Page_Load : L'utilisateur est déjà authentifié; redirection vers la page d'accueil.");

                    //Redirected to default page if already connected.
                    //Different from FormsAuthentication.RedirectFromLoginPage because no need to redefine Context.User.
                    Response.Redirect("Index.aspx");
                }
            }
        }

        protected void BtnConnect_Click(object sender, EventArgs e)
        {
            if (Membership.Provider is CustomMembershipProvider)
            {
                if (Membership.ValidateUser(TxtLogin.Text, TxtPassword.Text))
                {
                    FormsAuthentication.RedirectFromLoginPage(TxtLogin.Text, false);

                    //Calls default Role Membership defined in web.config.
                    Context.User = new GenericPrincipal(new GenericIdentity(TxtLogin.Text), ((RolePrincipal)Context.User).GetRoles());
                }
            }
            else
            {
                //ConnectionFailedMessage.Visible = true;
                System.Diagnostics.Trace.TraceWarning("[Login.aspx] - BtnConnect_Click : La connexion a échoué");
            }
        }
    }
}