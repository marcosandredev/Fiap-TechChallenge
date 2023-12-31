﻿namespace CBF.Domain.DTOs.Request
{
    public class JogadorUpdateRequest
    {
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public int Posicao { get; set; }
        public int PePreferido { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
    }
}
