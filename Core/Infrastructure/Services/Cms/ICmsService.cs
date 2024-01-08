using Core.DTO.Cms;
using Core.DTO.Cms.Properties;

namespace Core.Infrastructure.Services.Cms
{
    public interface ICmsService
    {
        Task<ResponseModel<RouteConfig>?> GetRoutesConfig();
    }
}
