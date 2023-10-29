using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBF.Domain.DTOs.Request
{
    public class ClubeRequest
    {
        public string Nome { get; set; }
        public DateTime DTFundacao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }        
        public string Pais { get; set; }
    }
}