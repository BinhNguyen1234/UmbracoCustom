

namespace Core.Data.Infrastucture
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void RollBack();

        void Save();

    }
}
