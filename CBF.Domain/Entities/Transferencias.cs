using CBF.Domain.Entities.Common;
using CBF.Domain.Entities.Enums;

namespace CBF.Domain.Entities
{
    public class Transferencias : EntityBase
    {
        public long IdJogador { get; set; }
        public long IdClubeAnterior { get; set; }
        public long IdClubeNovo { get; set; }
        public long IdTemporada { get; set; }
        public TipoTransferencia TipoTransferencia { get; set; }
        public DateTime DtTransferencia { get; set; }
        public DateTime DtInicioContrato { get; set; }
        public DateTime DtPrevisaoFimContrato { get; set; }
        public double VlTransferencia { get; set; }
        public Jogador Jogador { get; set; }
        public Clube ClubeAnterior { get; set; }
        public Clube ClubeNovo { get; set; }
        public Temporada Temporada { get; set; }
    }
}
