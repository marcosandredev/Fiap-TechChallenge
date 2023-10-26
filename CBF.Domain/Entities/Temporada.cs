using CBF.Domain.Entities.Common;

namespace CBF.Domain.Entities;
public class Temporada : EntityBase
{
    public string Nome { get; set; }
    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }
}
