using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private CmsContext _dbContext;
        private DbSet<TEntity> _dbSet;
        public GenericRepository(CmsContext dbContext) {
            this._dbContext = dbContext;
            this._dbSet = dbContext.Set<TEntity>();
        }
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
    }
}
