namespace CBF.Domain.DTOs.Response;
public class TemporadaResponse
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public bool Ativo { get; set; }
    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }
}
