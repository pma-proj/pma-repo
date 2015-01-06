using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PMAServices.DTO
{
    [DataContract(Namespace = "http://PMAServices/DTO")]
    public class ProjectDataReturn
    {
        [DataMember]
        public ProjectModel model { get; set; }
    }
}