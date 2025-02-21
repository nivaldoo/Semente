using Domain.Entities;

namespace Domain.Interfaces.Services;

public interface IBaseService<TEntity> : IBaseListService<TEntity> where TEntity : BaseEntity
{
  
}
