using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;
using Infrastructure.Repositories;

namespace Infrastructure;

public class UnitOfWork : IUnitOfWork
{
  protected readonly SqlContext sqlContext;

  public UnitOfWork(SqlContext sqlContext)
  {
    this.sqlContext = sqlContext;
  }

  public IBaseListRepository<TEntity> GetViewRepository<TEntity>() where TEntity : class
  {
    return new BaseListRepository<TEntity>(sqlContext);
  }
}
