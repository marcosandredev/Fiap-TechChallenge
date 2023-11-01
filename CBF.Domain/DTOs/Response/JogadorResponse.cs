using CBF.Domain.Entities.Enums;

namespace CBF.Domain.DTOs.Response
{
    public class JogadorResponse
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public Posicao Posicao { get; set; }
        public PePreferido PePreferido { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public IEnumerable<JogadorTransferenciaResponse> Transferencias { get; set; }
    }
}
