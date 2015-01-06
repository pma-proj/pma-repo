using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMAWeb.DTO
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int OwnerId { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
    }
}