using Core.Configure;
using Core.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;
using Core.Mapper;
using Core.Infrastructure.Service;
using Core.Infrastructure.Services.Cms;
using Core.Services.Extension;
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
            services.AddRepositories();
            services.AddInternalServices();
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
