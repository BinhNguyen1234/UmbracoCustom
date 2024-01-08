using Core.Data.Infrastucture;
using Core.Data.Model;

namespace Core.Data.Repositories {
    public interface IRouteRepository
    {
        IEnumerable<RouteModel> GetAll();
    }
}