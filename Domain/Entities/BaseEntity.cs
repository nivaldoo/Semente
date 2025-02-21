namespace Domain.Entities;

public class BaseEntity : BaseEntityActive
{
  public Guid Id { get; set; }
  public bool IsDeleted { get; set; }
  public DateTime CreatedAt { get; set; }
  public Guid IdCreateUser { get; set; }
  public DateTime? UpdatedAt { get; set; }
  public Guid? IdUpdateUser { get; set; }
}
