using CBF.Domain.Entities.Enums;

namespace CBF.Domain.DTOs.Response;
public class JogadorTransferenciaResponse
{
    public string ClubeAnterior { get; set; }
    public string ClubeNovo { get; set; }
    public TemporadaResponse Temporada { get; set; }
    public TipoTransferencia TipoTransferencia { get; set; }
    public double VlTransferencia { get; set; }
}
