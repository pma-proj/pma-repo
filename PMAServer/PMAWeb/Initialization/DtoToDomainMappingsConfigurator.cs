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
            AutoMapper.Mapper.CreateMap<PMAInfrastructure.Model.ProjectModel, DTO.ProjectModel>();
            AutoMapper.Mapper.CreateMap<PMABusiness.DTO.ProjectDataReturn, DTO.ProjectDataReturn>();

            AutoMapper.Mapper.CreateMap<PMAInfrastructure.Model.ProjectModel, PMAServices.DTO.ProjectModel>();
            AutoMapper.Mapper.CreateMap<PMABusiness.DTO.ProjectDataReturn, PMAServices.DTO.ProjectDataReturn>();

            AutoMapper.Mapper.CreateMap<PMAServices.DTO.ProjectModel, DTO.ProjectModel>();
            AutoMapper.Mapper.CreateMap<PMAServices.DTO.ProjectDataReturn, DTO.ProjectDataReturn>();
        }
    }
}