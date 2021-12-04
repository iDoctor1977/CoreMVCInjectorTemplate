using AutoMapper;
using Injector.Common.DTOModels;
using Injector.Web.Models;

namespace Injector.Web.MapperProfiles
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<VMCreateA, DTOModelA>().ReverseMap();
        }
    }
}
