using PMAInfrastructure.DataAccess;
using PMAInfrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMAInfrastructure.Repository
{
    public class ProjectRepository
    {
        ProjectDataDataContext _projectDb;

        public List<ProjectModel> GetProjects()
        {
            _projectDb = new ProjectDataDataContext();

            var project = new ProjectModel();
            var results = _projectDb.fcn_GetProjects();
            int c = results.Count();

            return results.Select(i => new ProjectModel
            {
                Id = i.Id,
                Name = i.Name,
                StartDate = i.StartDate,
                EndDate = i.EndDate,
                OwnerId = i.OwnerId,
                OwnerFirstName = i.OwnerFirstName,
                OwnerLastName = i.OwnerLastName
            }).ToList();

        }

        public ProjectModel GetProjects(string name)
        {
            _projectDb = new ProjectDataDataContext();

            var project = new ProjectModel();
            var results = _projectDb.fcn_GetProjectsByName(name);
            int c = results.Count();

            return results.Select(i => new ProjectModel
            {
                Id = i.Id,
                Name = i.Name,
                StartDate = i.StartDate,
                EndDate = i.EndDate,
                OwnerId = i.OwnerId,
                OwnerFirstName = i.OwnerFirstName,
                OwnerLastName = i.OwnerLastName
            }).SingleOrDefault();
        }

        public ProjectModel GetProject(string firstName, string lastName)
        {
            _projectDb = new ProjectDataDataContext();

            var project = new ProjectModel();
            var results = _projectDb.fcn_GetProjectsByOwnerName(firstName, lastName);
            int c = results.Count();

            return results.Select(i => new ProjectModel
            {
                Id = i.Id,
                Name = i.Name,
                StartDate = i.StartDate,
                EndDate = i.EndDate,
                OwnerId = i.OwnerId,
                OwnerFirstName = i.OwnerFirstName,
                OwnerLastName = i.OwnerLastName
            }).SingleOrDefault();
        }
    }
}
