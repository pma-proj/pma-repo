using PMABusiness.DTO;
using PMAInfrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMABusiness
{
    public class AssignmentTasks
    {
        AssignmentRepository _assignmentDb;

        public AssignmentTasks()
        {
            _assignmentDb = new AssignmentRepository();
        }

        public AssignmentDataReturn GetAssignments()
        {
            return new AssignmentDataReturn { Model = _assignmentDb.GetAssignments() };
        }
    }
}
