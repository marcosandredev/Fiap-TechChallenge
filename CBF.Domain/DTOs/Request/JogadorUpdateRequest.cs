using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.DTOs.Request
{
    public class JogadorUpdateRequest
    {
        public string Nome { get; set; }
        public int Posicao { get; set; }
        public int PePreferido { get; set; }
        public double Peso { get; set; }
    }
}
