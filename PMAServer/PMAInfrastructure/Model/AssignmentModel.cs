using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMAInfrastructure.Model
{
    public class AssignmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MemberId { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
}
