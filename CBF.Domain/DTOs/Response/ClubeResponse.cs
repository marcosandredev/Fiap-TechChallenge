namespace CBF.Domain.DTOs.Response
{
    public class ClubeResponse
    {
        public long ID { get; set; }

        public string Nome { get; set; }

        public DateTime DTFundacao { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }
        public IEnumerable<JogadorResponse> Jogadores { get; set; }
    }
}