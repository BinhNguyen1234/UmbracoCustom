using Core.Services.Interface;

namespace Core.Services.Extension
{
    public static class Extension
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services)
        {
            services.AddScoped<IRoutesService, RoutesService> ();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
