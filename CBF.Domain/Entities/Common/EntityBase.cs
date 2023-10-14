namespace CBF.Domain.Entities.Common;
public abstract class EntityBase
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime? Updated { get; set; } = DateTime.Now;
}
