
using AutoMapper;
using CMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;

namespace CMS.Mapper
{
    public class MapperContent : Profile
    {
        public MapperContent() {
            ShouldMapField = fi => false;
            CreateMap<IProperty, RouteConfigVM>()
                .ForMember(des => des.route, act => act.MapFrom(src => src.ValueStorageType))
                .ForMember(des => des.content, act => {
                    act.PreCondition(src => src.Alias.Equals("name_of_route"));
                    act.MapFrom(src => src.Alias);
                });
        }
    }
}
