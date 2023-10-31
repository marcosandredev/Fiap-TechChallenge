using CBF.Domain.Entities.Enums;

namespace CBF.Domain.DTOs.Response
{
    public class TransferenciaResponse
    {
        public long Id { get; set; }
        public JogadorResponse Jogador { get; set; }
        public ClubeResponse ClubeAnterior { get; set; }
        public ClubeResponse ClubeNovo { get; set; }
        public TemporadaResponse Temporada { get; set; }
        public TipoTransferencia TipoTransferencia { get; set; }
        public double VlTransferencia { get; set; }
    }
}
