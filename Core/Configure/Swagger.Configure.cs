using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Core.Configure
{
    public class SwaggerConfigure : IDocumentFilter
    {
        private string _prefix;
        public SwaggerConfigure(string prefix)
        {
            _prefix = prefix;
        }
        public void Apply(OpenApiDocument document, DocumentFilterContext context)
        {
            var paths = document.Paths.Keys.ToList();
            foreach (var path in paths)
            {
                var pathToChange = document.Paths[path];
                document.Paths.Remove(path);
                if (pathToChange != null) document.Paths.Add("/" + _prefix + path, pathToChange);
            }
        }
    }
}
