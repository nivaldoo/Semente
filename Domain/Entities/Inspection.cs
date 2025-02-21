namespace Domain.Entities;

public class Inspection : BaseEntity
{
  public Guid IdStatusInspection { get; set; }

  public StatusInspection StatusInspection { get; set; } = null!;
}
