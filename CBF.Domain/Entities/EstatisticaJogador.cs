using CBF.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.Entities
{
    public class EstatisticaJogador : EntityBase
    {
        public int IdJogador { get; set; }
        public int Ano { get; set; }
        public int Partidas { get; set; }
        public int Gols { get; set; }
        public int Assistencias { get; set; }
        public int Amarelos { get; set; }
        public int Vermelhos { get; set; }
        public Jogador Jogador { get; set; }
    }
}
