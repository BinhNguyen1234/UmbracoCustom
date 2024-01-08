using Core.Data.Model;
using Core.Data.Repositories;

namespace Core.Data.Extension {
    public static class Extension {
        public static IServiceCollection AddRepositories (this IServiceCollection services){
            services.AddScoped<IRouteRepository,RouteRepository>();
            return services;
        }
    }
}