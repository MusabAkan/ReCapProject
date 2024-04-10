using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(expression);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context = new TContext())
            {
                return expression == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(expression).ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var entityAdded = context.Entry(entity);
                entityAdded.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var entityDeleted = context.Entry(entity);
                entityDeleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var entityUpdated = context.Entry(entity);
                entityUpdated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
