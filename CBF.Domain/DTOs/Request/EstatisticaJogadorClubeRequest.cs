using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.DTOs.Request
{
    public class EstatisticaJogadorClubeRequest
    {
        public long IdJogador { get; set; }
        public long IdClube { get; set; }
        public long IdTemporada { get; set; }
        public int Ano { get; set; }
        public int Partidas { get; set; }
        public int Gols { get; set; }
        public int Assistencias { get; set; }
        public int Amarelos { get; set; }
        public int Vermelhos { get; set; }
    }
}
