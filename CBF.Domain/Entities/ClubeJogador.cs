using CBF.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.Entities
{
    public class ClubeJogador : EntityBase
    {
        public long IdJogador { get; set; }
        public long IdClube { get; set; }
        public DateTime DtInicioContrato { get; set; }
        public DateTime? DtFimContrato { get; set; }
        public double Salario { get; set; }
        public Jogador Jogador { get; set; }
        public Clube Clube { get; set; }
    }
}
