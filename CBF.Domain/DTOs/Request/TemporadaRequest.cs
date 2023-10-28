namespace CBF.Domain.DTOs.Request;
public class TemporadaRequest
{
    public string Nome { get; set; }
    public bool Ativo { get; set; }
    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }
}
