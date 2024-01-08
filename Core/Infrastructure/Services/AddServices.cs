using Core.Infrastructure.Services.Cms;

namespace Core.Infrastructure.Service
{
    public static class AddServices
    {
        public static IServiceCollection AddAllService(this IServiceCollection services)
        {
            services.AddScoped<ICmsService, CmsService>();
            return services;
        }
    }
}
