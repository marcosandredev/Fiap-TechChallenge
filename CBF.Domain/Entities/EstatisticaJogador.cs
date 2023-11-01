using CBF.Domain.Entities.Common;

namespace CBF.Domain.Entities
{
    public class EstatisticaJogador : EntityBase
    {
        public long IdJogador { get; set; }
        public long IdTemporada { get; set; }
        public int Partidas { get; set; }
        public int Gols { get; set; }
        public int Assistencias { get; set; }
        public int Amarelos { get; set; }
        public int Vermelhos { get; set; }
        public Jogador Jogador { get; set; }
        public Temporada Temporada { get; set; }
    }
}
