using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.ApplicationBuilder;
using Umbraco.Extensions;
using CmsCore.ControllerCustom;
using CMS.Extension;
using Microsoft.OpenApi.Models;
using Serilog;
using CMS.Configure;
using CMS.Configure.Swagger;

namespace CmsCore.Composer
{
    public class CustomRoute : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddSerilog();
            builder.Services.AddRouting(options => options.LowercaseUrls = true);
            builder.MapCustomControllersRoutes();
            builder.Services.ConfigureSwaggerGen(options =>
            {
                options.DocumentFilter<SwaggerDocConfigure>();
            });
        }
    }
}
