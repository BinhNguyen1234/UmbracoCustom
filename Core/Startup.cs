using Core.Configure;
using Core.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;
using Core.Mapper;
using Core.Infrastructure.Service;
using Core.Infrastructure.Services.Cms;
using Core.Services.Extension;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
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
            app.UseAuthentication();
            
            app.MapGrpcService<TestGrpc>();
            app.Map("/api", app =>
            {
                app.UseRouting();
                app.UseAuthorization();
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
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _builder.Configuration["Jwt:Issuer"],
                    ValidAudience = _builder.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_builder.Configuration["Jwt:Key"])),
                };
                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        Console.WriteLine("OnAuthenticationFailed: " +
                            context.Exception.Message);
                        return Task.CompletedTask;
                    },
                    OnTokenValidated = context =>
                    {
                        Console.WriteLine("OnTokenValidated: " +
                            context.SecurityToken);
                        return Task.CompletedTask;
                    }
                };
            });
            services.AddAuthorization();
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
            services.AddAutoMapper(typeof(DtoToEntites).Assembly, typeof(EntiesToDbModelProfile).Assembly, typeof(RequestDTOProfile).Assembly);

#if DEBUG
            services.AddSwaggerGen(c =>
            {
                c.DocumentFilter<AddPrefixForApiRoute>();
            });
#endif
        }
    }
}
