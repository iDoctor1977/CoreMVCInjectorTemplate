using AutoMapper;
using Injector.Common.Models;
using Injector.Web.Models;

namespace Injector.Web.MapperProfiles
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<CreateViewModel, CreateRequestTransfertModel>().ReverseMap();
            CreateMap<CreateViewModel, CreateResponseTransfertModel>().ReverseMap();
        }
    }
}
