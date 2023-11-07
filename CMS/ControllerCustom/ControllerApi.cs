using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Web.Common.ApplicationBuilder;

namespace CmsCore.ControllerCustom
{
    public static class ControllerApi
    {
        public static void MapCustomControllersRoutes(this IUmbracoBuilder builder)
        {
            builder.Services.AddRouting(options => options.LowercaseUrls = true);
            builder.Services.Configure<UmbracoPipelineOptions>(options =>
            {
                options.AddFilter(new UmbracoPipelineFilter("api")
                {
                    Endpoints = app =>
                    {
                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllerRoute("test", "{controller}/{action}");
                        });
                    }
                }); ;
            });
        }
    }
}
