using Core.DTO;
using Core.Infrastructure.Database;
using Core.Infrastructure.Database.Infrastucture;
using Core.Infrastructure.Database.Model;
using Core.Infrastructure.Database.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Database.Repositories
{
    public class RouteRepository : GenericRepositoryBase<Routes>, IRouteRepository
    {
        public RouteRepository(CoreContext dbContext) : base(dbContext) { }
        public async Task<IList<Routes>> GetAll()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }
        public async Task AddRoutes(IList<Routes> routes)
        {
            await _dbSet.AddRangeAsync(routes);
        }

        public async Task SaveAsync()
        {
            await base.SaveChangeAsync();
        }
    }
}