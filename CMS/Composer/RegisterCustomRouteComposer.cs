using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using AutoMapper;
using CMS.Mapper;
namespace CmsCore.Composer
{
    public class CustomRoute : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.Configure<RouteOptions>(options =>
            {
                options.LowercaseUrls = true;
            });
            builder.Services.AddAutoMapper(typeof(MapperContent).Assembly);
        }
    }
}
