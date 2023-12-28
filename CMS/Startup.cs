using CMS.Mapper;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace CMS
{
    public class Startup: IComposer
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