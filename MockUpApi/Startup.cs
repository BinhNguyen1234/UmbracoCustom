
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.IO;
using System.Linq;
namespace StartUp
{
    public class Startup
    {
        private WebApplicationBuilder _builder;
        public Startup(WebApplicationBuilder builder, IWebHostEnvironment env)
        {
            this._builder = builder;
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {

            app.Map("/api", app =>
            {
                app.UseRouting();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            });
#if DEBUG
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                //c.SwaggerEndpoint("/","MockUp Api");
            });
#elif RELEASE

#endif
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>((options) => { options.LowercaseUrls = true; });
            services.AddControllers();

#if DEBUG
            services.AddSwaggerGen(c =>
            {
                c.DocumentFilter<ConfigSwagger>();
            });
#endif
        }
    }
    class ConfigSwagger : IDocumentFilter
    {
        private string _prefix = "/api";

        public void Apply(OpenApiDocument document, DocumentFilterContext context)
        {
            var paths = document.Paths.Keys.ToList();
            foreach (var path in paths)
            {
                var pathToChange = document.Paths[path];
                document.Paths.Remove(path);
                if (pathToChange != null) document.Paths.Add(_prefix + path, pathToChange);
            }
        }
    }
}
