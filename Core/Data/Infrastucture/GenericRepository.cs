using Core.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.Data.Infrastucture
{
    public abstract class GenericRepositoryBase<Model> where Model : class, IBaseModel
    {
        protected readonly CoreContext _dbContext;
        protected readonly DbSet<Model> _dbSet;
        public GenericRepositoryBase(CoreContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<Model>();
        }
    }
}
