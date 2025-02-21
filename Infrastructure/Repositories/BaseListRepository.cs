using System.Linq.Expressions;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class BaseListRepository<TEntity> : IBaseListRepository<TEntity> where TEntity : class
{
  protected readonly SqlContext sqlContext;
  protected readonly DbSet<TEntity> dbSet;

  public BaseListRepository(SqlContext sqlContext)
  {
    this.sqlContext = sqlContext;
    dbSet = this.sqlContext.Set<TEntity>();
  }

  public IQueryable<TEntity> Get(bool isNoTracking)
  {
    return (isNoTracking) ? dbSet.AsNoTracking() : dbSet.AsQueryable();
  }

  public IQueryable<TEntity> Get(bool isNoTracking, params Expression<Func<TEntity, object>>[] includeProperties)
  {
    return includeProperties
    .Aggregate(
      Get(isNoTracking),
      (current, include) => current.Include(include));
  }
}
