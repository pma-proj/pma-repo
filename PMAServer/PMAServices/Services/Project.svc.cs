using PMABusiness;
using PMAServices.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PMAServices.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ProjectServices : IProjectServices
    {
        ProjectTasks projectTasks = new ProjectTasks(); 
        public ProjectDataReturn GetProjects()
        {
            var result = projectTasks.GetProjects();

            return AutoMapper.Mapper.Map<PMABusiness.DTO.ProjectDataReturn, ProjectDataReturn>(result);
        }

        public ProjectDataReturn GetProjects(string name)
        {
            var result = projectTasks.GetProjects(name);

            return AutoMapper.Mapper.Map<PMABusiness.DTO.ProjectDataReturn, ProjectDataReturn>(result);
        }

        public ProjectDataReturn GetProjects(string firstName, string lastName)
        {
            var result = projectTasks.GetProjects(firstName, lastName);

            return AutoMapper.Mapper.Map<PMABusiness.DTO.ProjectDataReturn, ProjectDataReturn>(result);
        }
    }

}
