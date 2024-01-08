namespace Core.Infrastructure.Database.Infrastucture.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void RollBack();

        void Save();

    }
}
