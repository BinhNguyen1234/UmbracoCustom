using CMS.Configure;
using CMS.Enum;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
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
                        app.UsePathBase(new PathString(Api.preFix));
                        
                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllerRoute("aaa", "{controller}/{action}");
                        });
                    }
                }); ;
            });
        }
    }
}
