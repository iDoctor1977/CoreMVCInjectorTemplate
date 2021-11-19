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
            CreateMap<VMEditA, DTOModelA>().ReverseMap();
            CreateMap<VMDeleteA, DTOModelA>().ReverseMap();

            CreateMap<VMCreateB, DTOModelB>().ReverseMap();
            CreateMap<VMEditB, DTOModelB>().ReverseMap();
            CreateMap<VMDeleteB, DTOModelB>().ReverseMap();

            CreateMap<EntityA, DTOModelA>().ReverseMap();
            CreateMap<EntityB, DTOModelB>().ReverseMap();
        }
    }
}
