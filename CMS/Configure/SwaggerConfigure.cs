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


namespace CMS.Configure.Swagger
{
    public class SwaggerDocConfigure : IDocumentFilter
    {
        private string _prefix = Api.preFix;
        
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var apiPaths = swaggerDoc.Paths.Keys.ToList();
            foreach ( var path in apiPaths)
            {
                var oldPath = swaggerDoc.Paths[path];
                var newPath = _prefix + path;
                swaggerDoc.Paths.Remove(path);
                swaggerDoc.Paths.Add(newPath, oldPath);
            }
        }
    }
}
