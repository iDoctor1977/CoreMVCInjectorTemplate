using AutoMapper;
using Injector.Common.Models;
using Injectore.Core.Models;

namespace Injectore.Core.MapperProfiles
{
    public class CoreMappingProfile : Profile
    {
        public CoreMappingProfile()
        {
            CreateMap<CreateModel, CreateRequestTransfertModel>().ReverseMap();
            CreateMap<CreateModel, CreateResponseTransfertModel>().ReverseMap();
        }
    }
}
