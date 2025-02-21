using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;

namespace Service.Services;

public class BaseService<TEntity> : BaseListService<TEntity>, IBaseService<TEntity> where TEntity : BaseEntity
{
  public BaseService(IUnitOfWork unitOfWork) : base(unitOfWork)
  {
  }
}
