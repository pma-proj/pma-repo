using PMABusiness.DTO;
using PMAInfrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMABusiness
{
    public class ProjectTasks
    {
        ProjectRepository _projectDb;

        public ProjectTasks()
        {
            _projectDb = new ProjectRepository();
        }

        public ProjectDataReturn GetProjects()
        {
            return new ProjectDataReturn { model = _projectDb.GetProjects() };
        }

        public ProjectDataReturn GetProjects(string projectName)
        {
            return new ProjectDataReturn { model = _projectDb.GetProjects(projectName) };
        }

        public ProjectDataReturn GetProjects(string firstName, string lastName)
        {
            return new ProjectDataReturn { model = _projectDb.GetProjects(firstName, lastName) };
        }
    }
}
