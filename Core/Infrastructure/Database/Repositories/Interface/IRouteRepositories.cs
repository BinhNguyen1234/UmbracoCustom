using Core.Infrastructure.Database.Infrastucture;
using Core.Infrastructure.Database.Model;

namespace Core.Infrastructure.Database.Repositories.Interface
{
    public interface IRouteRepository
    {
        Task<IList<RouteModel>> GetAll();
        Task AddRoutes(IList<RouteModel> routes);
        Task<int> SaveChange();
    }
}