using Core.Models;
using Core.Repositories;

namespace Core.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void RollBack();    
    }
}
