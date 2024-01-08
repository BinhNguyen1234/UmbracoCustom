using Core.Infrastructure.Database.Model;
using Core.Infrastructure.Database.Repositories.Interface;
using Core.Infrastructure.Services.Cms;

namespace Core.Services.Interface
{
    public interface IRoutesService
    {
        Task AddRouteToDb(IList<RouteModel> routes);
        Task<IList<RouteModel>> GetAllRoutesFromDb();
        Task<IList<RouteModel>?> GetRoutesFromCmsAsync();
        void GetRoutesFromCached();
        Task<IList<RouteModel>?> AddRoutesToDbIfNotExist();

    }
}
