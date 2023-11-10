
using CMS.Enum;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Web.Common.ApplicationBuilder;

namespace CmsCore.ControllerCustom
{
    public static class Startup
    {
        public static void MapCustomControllersRoutes(this IUmbracoBuilder builder)
        {
            builder.Services.Configure<UmbracoPipelineOptions>(options =>
            {
                options.AddFilter(new UmbracoPipelineFilter("api")
                {
                    Endpoints = app =>
                    {
                        app.UsePathBase(new PathString(Api.preFix));
                        app.UseRouting();
                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllers();
                        });
                    }
                });
                
            });
        }
    }
}
