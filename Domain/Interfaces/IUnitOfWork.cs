using Domain.Interfaces.Repositories;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
  IBaseListRepository<TEntity> GetViewRepository<TEntity>() where TEntity : class;
}
