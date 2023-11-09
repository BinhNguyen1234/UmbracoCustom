using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Configure;
using CMS.Enum;
using System.IO;
using Umbraco.Cms.Web.Common.ApplicationBuilder;
using Umbraco.Cms.Api.Common.OpenApi;
using Umbraco.Cms.Core.Composing;

namespace CMS.Configure.Swagger
{
    public class SwaggerDocConfigure : IDocumentFilter
    {
        private string _prefix = Api.preFix;
        
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var newInfo = new OpenApiInfo() { Title = "Extend Api", Version = "1", Description = "For test"};
            swaggerDoc.Info = newInfo;
            var apiPaths = swaggerDoc.Paths.Keys.ToList();
            foreach ( var key in apiPaths)
            {
                var oldPath = swaggerDoc.Paths[key];
                var newPath = _prefix + key;
                 
                swaggerDoc.Paths.Remove(key);
                swaggerDoc.Paths.Add(newPath, oldPath);
            }
        }
    }
    public class SwaggerRouteConfigure : SwaggerRouteTemplatePipelineFilter
    {
        public SwaggerRouteConfigure() : base("ttt")
        {

        }
    }


}
