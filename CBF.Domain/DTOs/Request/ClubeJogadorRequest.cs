namespace CBF.Domain.DTOs.Request;
public class ClubeJogadorRequest
{
    public long IdClube { get; set; }
    public DateTime DtInicioContrato { get; set; }
    public DateTime? DtFimContrato { get; set; }
    public double Salario { get; set; }
}

public class ClubeJogadorUpdateRequest : ClubeJogadorRequest
{
    public long Id { get; set; }
}
