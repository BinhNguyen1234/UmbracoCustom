using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.Data.Infrastucture
{
    public abstract class GenericRepositoryBase<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private BlogContext _dbContext;
        private DbSet<TEntity> _dbSet;
        public GenericRepositoryBase(BlogContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public virtual TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteMulti(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
