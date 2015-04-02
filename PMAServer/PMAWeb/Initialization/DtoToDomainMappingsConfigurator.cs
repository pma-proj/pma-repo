using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMAWeb.Initialization
{
    public class DtoToDomainMappingsConfigurator
    {
        public static void MapObjects()
        {
            //Infrastructure/Business => Web.
            AutoMapper.Mapper.CreateMap<PMAInfrastructure.Model.ProjectModel, DTO.ProjectModel>();
            AutoMapper.Mapper.CreateMap<PMABusiness.DTO.ProjectDataReturn, DTO.ProjectDataReturn>();

            AutoMapper.Mapper.CreateMap<PMAInfrastructure.Model.MemberModel, DTO.MemberModel>();
            AutoMapper.Mapper.CreateMap<PMABusiness.DTO.MemberDataReturn, DTO.MemberDataReturn>();


            //Infrastructure/Business => Services.
            AutoMapper.Mapper.CreateMap<PMAInfrastructure.Model.ProjectModel, PMAServices.DTO.ProjectModel>();
            AutoMapper.Mapper.CreateMap<PMABusiness.DTO.ProjectDataReturn, PMAServices.DTO.ProjectDataReturn>();
        }
    }
}