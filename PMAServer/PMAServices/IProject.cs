using PMAServices.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PMAServices
{
    [ServiceContract(Namespace = "http://PMAServices")]
    public interface IProjectServices
    {
        [OperationContract]
        [DataContractFormat(Style= OperationFormatStyle.Rpc)]
        ProjectDataReturn GetProjects(string name);

        [OperationContract]
        [DataContractFormat(Style = OperationFormatStyle.Rpc)]
        ProjectDataReturn GetProjects(string firstName, string lastName);
    }

}
