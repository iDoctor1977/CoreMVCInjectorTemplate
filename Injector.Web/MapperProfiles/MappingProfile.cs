using AutoMapper;
using Injector.Common.DTOModels;
using Injector.Data.ADOModels;
using Injector.Web.Models;

namespace Injector.Web.MapperProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VMCreateA, DTOModelA>().ReverseMap();
            CreateMap<EntityA, DTOModelA>().ReverseMap();
        }
    }
}
