namespace Domain.Entities;

public class StatusInspection : BaseEntityActive
{
  public Guid Id { get; set; }

  public string Name { get; set; } = null!;

  public Guid? IdNextStatus { get; set; }

  public Guid? IdErrorStatus { get; set; }

  public string StatusType { get; set; } = null!;

  public ICollection<Inspection> Inspections { get; set; } = null!;
}
