using PMAServices;
using PMAWeb.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoMapper;
using PMAServices.Services;
using System.Web.Security;
using PMABusiness;

namespace PMAWeb.Pages
{
    public partial class Projects : System.Web.UI.Page
    {
        ProjectTasks projectTasks = new ProjectTasks();
        ProjectDataReturn dataReturn = new ProjectDataReturn();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!Context.User.Identity.IsAuthenticated)
                {
                    System.Diagnostics.Trace.TraceWarning("[Projects.aspx] - Page_Load : L'utilisateur n'est pas authentifié; redirection vers la page de Login.");

                    FormsAuthentication.RedirectToLoginPage();
                    return;
                }
            }

            dataReturn = Mapper.Map<PMABusiness.DTO.ProjectDataReturn, DTO.ProjectDataReturn>(projectTasks.GetProjects());

            if (dataReturn.Model.Count > 0)
                Repeater1.DataSource = dataReturn.Model;
            else
                Repeater1.DataSource = new List<ProjectModel>();

            Repeater1.DataBind();
        }
    }
}