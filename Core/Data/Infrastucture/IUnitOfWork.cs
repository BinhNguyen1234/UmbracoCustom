using Core.Models;
using Core.Repositories;

namespace Core.Data.Infrastucture
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void RollBack();
    }
}
