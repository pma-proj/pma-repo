using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PMAServices.DTO
{
    [DataContract(Namespace = "http://PMAServices/DTO")]
    public class ProjectModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public DateTime EndDate { get; set; }

        [DataMember]
        public int OwnerId { get; set; }

        [DataMember]
        public string OwnerFirstName { get; set; }

        [DataMember]
        public string OwnerLastName { get; set; }
    }
}