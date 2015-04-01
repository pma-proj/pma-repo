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

        }

        protected void HLDisconnect_Click(object sender, EventArgs e)
        {
            if(Context.User.Identity.IsAuthenticated)
            FormsAuthentication.SignOut();

            FormsAuthentication.RedirectToLoginPage();
        }
    }
}