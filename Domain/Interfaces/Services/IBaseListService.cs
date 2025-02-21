using System.Linq.Expressions;
using Domain.Entities;

namespace Domain.Interfaces.Services;

public interface IBaseListService<TEntity> where TEntity: BaseEntityActive
{
  IQueryable<TEntity> GetIsActive(params Expression<Func<TEntity, object>>[] includeProperties);
}
