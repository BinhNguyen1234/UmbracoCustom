namespace Core.Data.Repositories.Extension
{
    public static class RepositoriesExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) {

            services.AddScoped<RouteRepository>();
            return services;
        }
    }
}
