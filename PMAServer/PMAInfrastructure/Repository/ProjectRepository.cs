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

            var results = _projectDb.fcn_GetProjects();
            
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

        public List<ProjectModel> GetProjects(string projectName)
        {
            _projectDb = new ProjectDataDataContext();

            var results = _projectDb.fcn_GetProjectsByName(projectName);

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

        public List<ProjectModel> GetProjects(string firstName, string lastName)
        {
            _projectDb = new ProjectDataDataContext();

            var results = _projectDb.fcn_GetProjectsByOwnerName(firstName, lastName);

            return results.Select(p => new ProjectModel
            {
                Id = p.Id,
                Name = p.Name,
                StartDate = p.StartDate,
                EndDate = p.EndDate,
                OwnerId = p.OwnerId,
                OwnerFirstName = p.OwnerFirstName,
                OwnerLastName = p.OwnerLastName
            }).ToList();
        }
    }
}
