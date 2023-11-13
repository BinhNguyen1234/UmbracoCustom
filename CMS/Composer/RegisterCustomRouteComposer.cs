using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

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
        }
    }
}
