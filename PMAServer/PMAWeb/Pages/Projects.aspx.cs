using PMAServices;
using PMAWeb.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoMapper;

namespace PMAWeb.Pages
{
    public partial class Projects : System.Web.UI.Page
    {
        ProjectServices projectServices = new ProjectServices();
        ProjectDataReturn dataReturn = new ProjectDataReturn();

        protected void Page_Load(object sender, EventArgs e)
        {
            dataReturn = Mapper.Map<PMAServices.DTO.ProjectDataReturn, DTO.ProjectDataReturn>(projectServices.GetProject("Ar", "Leb"));

            List<ProjectDataReturn> list = new List<ProjectDataReturn>();
            list.Add(dataReturn);

            Repeater1.DataSource = list;
            Repeater1.DataBind();
        }

        private void LoadProjects()
        {
            string ownerFirstName = "Jason";
        }
    }
}