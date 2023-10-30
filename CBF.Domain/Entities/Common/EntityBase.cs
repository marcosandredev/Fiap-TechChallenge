namespace CBF.Domain.Entities.Common;
public abstract class EntityBase
{
    public long Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTime CriadoEm { get; set; }
    public DateTime AtualizadoEm { get; set; }
}
