using AutoMapper;
using Core.Entities;
using Core.DTO.Cms.Properties;
namespace Core.Mapper
{
    public class DtoToEntites : Profile
    {
        public DtoToEntites() : base()
        {
            ShouldMapField = (fileInfo) =>
            {
                return false;
            };
            CreateMap<RouteConfig, RouteEntites>()
                .ForMember(d => d.name, opt => opt.MapFrom(s => s.name_custom))
                .ForMember(d => d.url, opt => opt.MapFrom(s => s.url));
        }
    }
}
