using CMS.Configure;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Web.Common.ApplicationBuilder;

namespace CmsCore.ControllerCustom
{
    public static class Startup
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
                        app.UseRouting();
                        app.Map("", app =>
                        {
                            app.UseEndpoints(endpoints =>
                            {
                                endpoints.MapControllerRoute("api", "{controller}/{action}");
                            });
                        }); 
                    }
                }); ;
            });
        }
    }
}
