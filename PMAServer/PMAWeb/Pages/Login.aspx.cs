using PMAWeb.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (Context.User.Identity.IsAuthenticated)
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void BtnConnect_Click(object sender, EventArgs e)
        {
            if (Membership.Provider is CustomMembershipProvider)
            {
                if (Membership.Provider.ValidateUser(TxtLogin.Text, TxtPassword.Text))
                {
                    FormsAuthentication.RedirectFromLoginPage(TxtLogin.Text, false);
                }
            }
        }
    }
}