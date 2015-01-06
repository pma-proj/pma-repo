using PMABusiness;
using PMABusiness.DTO;
using PMAWeb.DTO;
using PMAWeb.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using PMAServices;

namespace PMAWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            DtoToDomainMappingsConfigurator.MapObjects();
            ProjectServices project = new ProjectServices();
            PMAServices.DTO.ProjectDataReturn proj = project.GetProject("Project 1");
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}