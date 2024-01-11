using Core.DTO;
using Core.Infrastructure.Database.Infrastucture;
using Core.Infrastructure.Database.Model;

namespace Core.Infrastructure.Database.Repositories.Interface
{
    public interface IRouteRepository
    {
        Task<IList<Routes>> GetAll();
        Task AddRoutes(IList<Routes> routes);
    }
}