using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("[controller]")]
public class InspectionController : ControllerBase
{
  private readonly IInspectionService inspectionService;

  public InspectionController(IInspectionService inspectionService)
  {
    this.inspectionService = inspectionService;
  }

  [HttpGet]
  public IActionResult Get()
  {
    var result = inspectionService.GetIsActive()
      .Take(2);
    return Ok(result);
  }
}
