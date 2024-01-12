using AutoMapper;
using Core.Entities;
using Core.DTO.Cms.Properties;
using Core.Infrastructure.Database.Model;
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
            CreateMap<RouteConfig, Routes>()
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.name_custom))
                .ForMember(d => d.Url, opt => opt.MapFrom(s => s.url));
        }
    }
}
