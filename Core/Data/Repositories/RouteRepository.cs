using Core.Data.Context;
using Core.Data.Infrastucture;
using Core.Data.Model;

namespace Core.Data.Repositories
{
    public class RouteRepository : GenericRepositoryBase<RouteModel>, IRouteRepository
    {
        public RouteRepository(CoreContext dbContext) : base(dbContext){}
        public IEnumerable<RouteModel> GetAll() {
            return _dbSet.AsEnumerable();
        }
    }
}
