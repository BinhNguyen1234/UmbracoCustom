using CMS.Services;
using Core.Configure;
using Core.Data;
using Core.Service.Cms;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using StackExchange.Redis;
using System.Net.Http;
using AutoMapper;
using Core.Mapper;
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
            app.MapGrpcService<TestGrpc>();
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
            services.AddGrpc();
            services.Configure<RouteOptions>((options) => { options.LowercaseUrls = true; });
            services.AddDbContextPool<CoreContext>(optionsBuilder =>
            {
                string? connectionString = _builder.Configuration.GetConnectionString("testDb");
                if (connectionString != null)
                {
                    optionsBuilder.UseNpgsql(connectionString);
                }
                
            });
            services.AddControllers();
            services.AddSingleton<IDatabase>(cfg =>
            {
                var conection = _builder.Configuration["ReddisCached:connectionString"];
                IConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect(conection);
                multiplexer.ConnectionFailed += (sender, evt) =>
                {
                    Console.WriteLine("Connect to redis server failed");
                };
                multiplexer.ConnectionRestored += (sender, evt) =>
                {
                    Console.WriteLine("Connect to redis server success");
                };
                
                return multiplexer.GetDatabase();
            });
            services.AddHttpClient<ICmsService, CmsService>(configure =>
            {
                configure.BaseAddress = new Uri("https://localhost:44338");
            });
            services.AddAutoMapper(typeof(DtoToEntites).Assembly, typeof(EntiesToDbModelProfile).Assembly);

#if DEBUG
            services.AddSwaggerGen(c =>
            {
                c.DocumentFilter<AddPrefixForApiRoute>();
            });
#endif
        }
    }
}
