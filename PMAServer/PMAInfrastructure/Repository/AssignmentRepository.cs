using PMAInfrastructure.DataAccess;
using PMAInfrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMAInfrastructure.Repository
{
    public class AssignmentRepository
    {
        AssignmentDataDataContext _assignmentDb;

        public List<AssignmentModel> GetAssignments()
        {
            _assignmentDb = new AssignmentDataDataContext();

            var results = _assignmentDb.fcn_GetAssignments();

            return results.Select(a => new AssignmentModel
            {
                Id = a.Id,
                Name = a.Name,
                StartDate = a.StartDate,
                EndDate = a.EndDate,
                MemberId = a.MemberId,
                MemberFirstName = a.MemberFirstName,
                MemberLastName = a.MemberLastName,
                ProjectId = a.ProjectId,
                ProjectName = a.ProjectName
            }).ToList();
        }
    }
}
