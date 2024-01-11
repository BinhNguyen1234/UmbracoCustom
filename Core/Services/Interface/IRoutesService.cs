using Core.DTO;
using Core.Infrastructure.Database.Model;
using Core.Infrastructure.Database.Repositories.Interface;
using Core.Infrastructure.Services.Cms;

namespace Core.Services.Interface
{
    public interface IRoutesService
    {
        Task AddRouteToDb(IList<Routes> routes);
        Task<IList<Routes>> GetAllRoutesFromDb();
        Task<IList<Routes>?> GetRoutesFromCmsAsync();
        void GetRoutesFromCached();
        Task<IList<Routes>?> AddRoutesToDbIfNotExist();

    }
}
