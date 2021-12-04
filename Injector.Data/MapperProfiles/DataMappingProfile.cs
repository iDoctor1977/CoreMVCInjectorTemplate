using AutoMapper;
using Injector.Common.DTOModels;
using Injector.Data.ADOModels;

namespace Injector.Data.MapperProfiles
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<EntityA, DTOModelA>().ReverseMap();
        }
    }
}
