using System.Linq.Expressions;

namespace Core.Data.Infrastucture
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Entity Add(Entity entity);
        Entity Update(Entity entity);
        Entity Delete(Entity entity);
        Entity Delete(int id);
        void DeleteMulti(Expression<Func<Entity, bool>> where);
    }
}
