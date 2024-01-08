using Core.Infrastructure.Database.Infrastucture.Interface;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Database.Infrastucture
{
    public class UnitOfWork : Disposable, IUnitOfWork, IDisposable
    {
        private readonly DbContext _dbContext;
        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
        public void RollBack()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
