using Core.Infrastructure.Database.Model;
using Core.Infrastructure.Database.Repositories;
using Core.Infrastructure.Database.Repositories.Interface;

namespace Core.Infrastructure.Database
{
    public static class Extension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRouteRepository, RouteRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}