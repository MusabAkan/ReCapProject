using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> expression);
        List<T> GetList(Expression<Func<T, bool>> expression = null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
