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

        public ProjectDataReturn GetProject(string name)
        {
            return new ProjectDataReturn { model = _projectDb.GetProjects(name) };
        }

        public ProjectDataReturn GetProject(string firstName, string lastName)
        {
            return new ProjectDataReturn { model = _projectDb.GetProject(firstName, lastName) };
        }
    }
}
