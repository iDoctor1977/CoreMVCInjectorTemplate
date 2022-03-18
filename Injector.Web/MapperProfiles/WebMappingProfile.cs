using AutoMapper;
using Injector.Common.Models;
using Injector.Web.Models;

namespace Injector.Web.MapperProfiles
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<CreateGetViewModel, CreateRequestTransfertModel>().ReverseMap();
            CreateMap<CreateGetViewModel, CreateResponseTransfertModel>().ReverseMap();
        }
    }
}
