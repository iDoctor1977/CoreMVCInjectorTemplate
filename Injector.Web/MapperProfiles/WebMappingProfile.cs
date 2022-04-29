using System.Reflection;
using AutoMapper;
using Injector.Common.Models;
using Injector.Web.Models;

namespace Injector.Web.MapperProfiles
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<CreateViewModel, CreateModel>()
                .ReverseMap();

            CreateMap<ReadViewModel, ReadModel>()
                .ForMember(source => source.ReadingDay, destination => destination.Ignore())
                .ReverseMap();
        }
    }
}
