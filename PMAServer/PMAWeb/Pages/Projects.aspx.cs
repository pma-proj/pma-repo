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

namespace PMAWeb.Pages
{
    public partial class Projects : System.Web.UI.Page
    {
        ProjectServices projectServices = new ProjectServices();
        ProjectDataReturn dataReturn = new ProjectDataReturn();

        protected void Page_Load(object sender, EventArgs e)
        {
            dataReturn = Mapper.Map<PMAServices.DTO.ProjectDataReturn, DTO.ProjectDataReturn>(projectServices.GetProjects());

            List<ProjectModel> list;
            if (dataReturn.model.Count > 0)
                list = dataReturn.model;
            else
                list = new List<ProjectModel>();

            Repeater1.DataSource = list;
            Repeater1.DataBind();
        }
    }
}