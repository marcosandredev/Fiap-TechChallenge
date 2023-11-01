namespace CBF.Domain.DTOs.Request
{
    public class TransferenciaRequest
    {
        public long IdJogador { get; set; }
        public long IdClubeAnterior { get; set; }
        public long IdClubeNovo { get; set; }
        public long IdTemporada { get; set; }
        public int TipoTransferencia { get; set; }
        public double VlTransferencia { get; set; }
        public DateTime DtTransferencia { get; set; }
        public DateTime DtInicioContrato { get; set; }
        public DateTime DtPrevisaoFimContrato { get; set; }

    }
}
