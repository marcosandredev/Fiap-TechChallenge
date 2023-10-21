using CBF.Domain.Entities.Common;
using CBF.Domain.Entities.Enums;

namespace CBF.Domain.Entities
{
    public class Jogador : EntityBase
    {
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public Posicao Posicao { get; set; }
        public PePreferido PePreferido { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public ICollection<Transferencias> Transferencias { get; set; }
        public ICollection<EstatisticaJogador> EstatisticasJogador { get; set; }
        public ICollection<EstatisticaJogadorClube> EstatisticasJogadorClube { get; set; }
        public ICollection<ClubeJogador> Clubes { get; set; }
    }
}
