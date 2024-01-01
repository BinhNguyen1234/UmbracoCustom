using CMS.Mapper;
using CMS.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Web.Common.ApplicationBuilder;

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
            builder.Services.AddGrpc();
            builder.Services.Configure<UmbracoPipelineOptions>(options =>
            {
                options.AddFilter(new UmbracoPipelineFilter("Rpc")
                {
                    Endpoints = app => app.UseEndpoints(endpoints =>
                    {
                        endpoints.MapGrpcService<TestGrpc>();
                    })
                });
            });
        }
    }
}