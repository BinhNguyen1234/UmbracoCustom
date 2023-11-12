using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using CmsCore.ControllerCustom;
using CMS.Configure.Swagger;
using Umbraco.Extensions;

namespace CmsCore.Composer
{
    public class CustomRoute : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddRouting(options => options.LowercaseUrls = true);
            builder.Services.ConfigureSwaggerGen(options =>
            {
                options.DocumentFilter<SwaggerDocConfigure>();
            });
            builder.MapCustomControllersRoutes();
        }
    }
}
