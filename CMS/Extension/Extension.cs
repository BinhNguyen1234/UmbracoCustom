using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using Swashbuckle.AspNetCore.SwaggerGen;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Web.Common.ApplicationBuilder;

namespace CMS.Extension
{

    public static class ExtensionSwagger { }

    
}
public static class MyConfigureSwaggerRouteUmbracoBuilderExtensions
{
    // call this from ConfigureServices() in Startup, i.e.:
    //     services.AddUmbraco(_env, _config)
    //         ...
    //         .ConfigureMySwaggerRoute()
    //         .Build();
    //public static IUmbracoBuilder ConfigureMySwaggerRoute(this IUmbracoBuilder builder)
    //{
    //    builder.Services.Configure<UmbracoPipelineOptions>(options =>
    //    {
    //        // include this line if you do NOT want the Swagger docs at /umbraco/swagger
    //        options.PipelineFilters.RemoveAll(filter => filter is SwaggerRouteTemplatePipelineFilter);

    //        // setup your own Swagger routes
    //        options.AddFilter(new MySwaggerRouteTemplatePipelineFilter("MyApi"));
    //    });
    //    return builder;
    //}
}
