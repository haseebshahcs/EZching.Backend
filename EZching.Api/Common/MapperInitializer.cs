using AutoMapper;
using EZching.Data.Entities;
using EZching.Models.SystemConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EZching.Api.Common
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<SystemConfig, SystemConfigResDTO>().ReverseMap();
        }
    }
}
