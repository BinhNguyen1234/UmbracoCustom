using AutoMapper;
using Core.DTO.RequesModel;
using Core.Entities;
using Core.Infrastructure.Database.Model;

namespace Core.Mapper
{
    public class RequestDTOProfile : Profile
    {
        public RequestDTOProfile() {
            CreateMap<RegisterForm, UserEntity>();
            CreateMap<UserEntity, User>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => Guid.NewGuid()));
           
        }
    }
}
