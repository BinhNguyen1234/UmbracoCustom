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
            foreach ( var key in apiPaths)
            {
                var oldPath = swaggerDoc.Paths[key];
                var newPath = _prefix + key;
                
                swaggerDoc.Paths.Remove(key);
                swaggerDoc.Paths.Add(newPath, oldPath);
            }
        }
    }
}
