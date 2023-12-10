
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
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
            app.UseSwaggerUI();
#elif RELEASE

#endif
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>((options) => { options.LowercaseUrls = true; });
            services.AddControllers();

#if DEBUG
#endif
        }
    }
}
