using Core.DTO.Cms;
using Core.DTO.Cms.Properties;

namespace Core.Service.Cms
{
    public interface ICmsService
    {
        Task<ResponseModel<RouteConfig>> GetRoutesConfig();
    }
}
