using Core.Data.Infrastucture;
using Core.Data.Model;

namespace Core.Data.Repositories
{
    public class RouteRepository : GenericRepositoryBase<RouteModel>
    {
        public RouteRepository(CoreContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<RouteModel> GetAll() {
            return _dbSet.AsEnumerable();
        }
    }
}
