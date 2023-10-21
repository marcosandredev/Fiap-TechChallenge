using CBF.Domain.Entities.Common;

namespace CBF.Domain.Entities
{
    public class Jogador : EntityBase
    {
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public string Posicao { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public ICollection<Transferencias> Transferencias { get; set; }
        public ICollection<EstatisticaJogador> EstatisticasJogador { get; set; }
        public ICollection<EstatisticaJogadorClube> EstatisticasJogadorClube { get; set; }
        public ICollection<ClubeJogador> Clubes { get; set; }
    }
}
