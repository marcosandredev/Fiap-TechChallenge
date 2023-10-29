using CBF.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.DTOs.Request
{
    public class JogadorRequest
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
