using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("[controller]")]
public class StatusInspectionController : ControllerBase
{
  private readonly IStatusInspectionService statusInspectionService;

  public StatusInspectionController(IStatusInspectionService statusInspectionService)
  {
    this.statusInspectionService = statusInspectionService;
  }

  [HttpGet]
  public IActionResult Get()
  {
    var result = statusInspectionService.GetIsActive()
      .OrderBy(o => o.Name);
    return Ok(result);
  }
}
