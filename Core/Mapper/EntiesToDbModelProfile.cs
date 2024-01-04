using AutoMapper;
using Core.Data.Model;
using Core.DTO.Cms.Properties;
using Core.Entities;

namespace Core.Mapper
{
    public class EntiesToDbModelProfile: Profile
    {
        public EntiesToDbModelProfile() {
            ShouldMapField = (fileInfo) =>
            {
                return false;
            };
            CreateMap<RouteEntites, RouteModel>()
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.name))
                .ForMember(d => d.Url, opt => opt.MapFrom(s => s.url))
                .ForMember(d => d.Id, opt => opt.MapFrom(s => Guid.NewGuid()));
        }
    }
}
