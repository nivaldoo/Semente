using System.Linq.Expressions;

namespace Domain.Interfaces.Repositories;

public interface IBaseListRepository<TEntity> where TEntity : class
{
  IQueryable<TEntity> Get(bool isNoTracking);
  IQueryable<TEntity> Get(bool isNoTracking, params Expression<Func<TEntity, object>>[] includeProperties);
}
