using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.DTOs.Response
{
    public class TransferenciaResponse
    {
        public long Id { get; set; }
        public long IdJogador { get; set; }
        public long IdClubeAnterior { get; set; }
        public long IdClubeNovo { get; set; }
        public long IdTemporada { get; set; }
        public int TipoTransferencia { get; set; }
        public double VlTransferencia { get; set; }
    }
}
