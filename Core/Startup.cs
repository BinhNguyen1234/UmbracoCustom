using Core.Context;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace Core
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
            app.Use((context, next) =>
            {
                context.Request.EnableBuffering();
                return next();
            });
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
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1");
            });
#elif RELEASE

#endif
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>((options) => { options.LowercaseUrls = true; });
            services.AddDbContextPool<CmsContext>(optionsBuilder =>
            {
                string? connectionString = _builder.Configuration.GetConnectionString("umbracoDbDSN");
                if (connectionString != null)
                {
                    optionsBuilder.UseSqlServer(connectionString);
                }
            });

#if DEBUG
            services.AddSwaggerGen(c =>
            {
                //c.DocumentFilter<SwaggerPathPrefixInsertDocumentFilter>("api");
                //c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            }
            );

#endif
        }
    }
}
