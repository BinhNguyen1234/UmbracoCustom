using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.Data.Infrastucture
{
    public class GenericRepositoryBase<TEntity> : IGenericRepository<TEntity> where TEntity : class, IBaseModel
    {
        protected readonly CoreContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;
        public  DbSet<TEntity> dbSet
        {
            get { return this._dbSet; }
        }
        public GenericRepositoryBase(CoreContext dbContext)
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
