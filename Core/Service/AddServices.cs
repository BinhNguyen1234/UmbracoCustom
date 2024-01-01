using Core.Service.Cms;

namespace Core.Service
{
    public static class AddServices
    {
        public static IServiceCollection AddAllService (this IServiceCollection services)
        {
            services.AddScoped<ICmsService, CmsService>();
            return services;
        } 
    }
}
