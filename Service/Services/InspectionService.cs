using Domain.Entities;
using RInspection.Service.Services;

namespace Domain.Interfaces.Services;

public class InspectionService : BaseService<Inspection>, IInspectionService
{
    public InspectionService(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}
