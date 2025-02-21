using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;

namespace Service.Services;

public class StatusInspectionsService : BaseListService<StatusInspection>, IStatusInspectionService
{
    public StatusInspectionsService(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}
