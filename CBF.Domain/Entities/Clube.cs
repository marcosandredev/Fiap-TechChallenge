using CBF.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.Entities
{
    public class Clube : EntityBase
    {
        public string Nome { get; set; }
        public DateTime DtFundacao { get; set; }
        public string Pais { get; set; }

        public ICollection<Transferencias> TransferenciasClubeAnterior { get; set; }
        public ICollection<Transferencias> TransferenciasClubeNovo { get; set; }
        public ICollection<EstatisticaJogadorClube> EstatisticasJogadorClube { get; set; }
        public ICollection<ClubeJogador> ClubesJogadores { get; set; }
    }
}
