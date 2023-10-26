using CBF.Domain.Entities.Common;

namespace CBF.Domain.Entities
{
    public class EstatisticaJogadorClube : EntityBase
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
        public Jogador Jogador { get; set; }
        public Clube Clube { get; set; }
        public Temporada Temporada { get; set; }
    }
}
