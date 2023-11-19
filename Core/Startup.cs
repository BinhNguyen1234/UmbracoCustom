using Core.Configure;
using Core.Infrastructure;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using StackExchange.Redis;
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
            app.UseSwaggerUI();
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
            services.AddControllers();
            services.AddStackExchangeRedisCache(options =>
            {
                
                options.Configuration = _builder.Configuration["ReddisCached:connectionString"];
                options.ConfigurationOptions = new ConfigurationOptions()
                {

                };
            });
            services.AddSingleton<IDatabase>(cfg =>
            {
                var conection = _builder.Configuration["ReddisCached:connectionString"];
                IConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect(conection);
                return multiplexer.GetDatabase();
            });

#if DEBUG
            services.AddSwaggerGen(c =>
            {
                c.DocumentFilter<AddPrefixForApiRoute>();
            });
#endif
        }
    }
}
