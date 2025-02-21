using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Service.Services;

public class BaseListService<TEntity> : IBaseListService<TEntity> where TEntity : BaseEntityActive
{
  private readonly IBaseListRepository<TEntity> listRepository;

  public BaseListService(IUnitOfWork unitOfWork)
  {
    listRepository = unitOfWork.GetViewRepository<TEntity>();
  }

  public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeProperties)
  {
    return listRepository.Get(true, includeProperties).Where(filter);
  }

  public virtual IQueryable<TEntity> GetIsActive(params Expression<Func<TEntity, object>>[] includeProperties)
  {
    return Get(where => where.IsActive, includeProperties);
  }
}
