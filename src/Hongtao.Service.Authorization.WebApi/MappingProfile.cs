using AutoMapper;
using Hongtao.Service.Authorization.Core;
using Hongtao.Service.Authorization.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hongtao.Service.Authorization.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterRequest, User>();
        }
    }
}
