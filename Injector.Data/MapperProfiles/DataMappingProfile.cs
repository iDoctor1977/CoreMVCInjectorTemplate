﻿using AutoMapper;
using Injector.Common.Models;
using Injector.Data.Entities;

namespace Injector.Data.MapperProfiles
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<AEntity, CreateModel>().ReverseMap();
            CreateMap<AEntity, ReadModel>().ReverseMap();
        }
    }
}
