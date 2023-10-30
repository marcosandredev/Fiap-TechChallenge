namespace CBF.Domain.DTOs.Response;
public class ClubeJogadorResponse
{
    public long Id { get; set; }
    public long IdClube { get; set; }
    public DateTime DtInicioContrato { get; set; }
    public DateTime? DtFimContrato { get; set; }
    public double Salario { get; set; }
}
