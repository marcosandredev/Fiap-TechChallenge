using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.DTOs.Request
{
    public class EstatisticasClubesRequest
    {
        public long idTemporada { get; set; }
        public bool Gols { get; set; }
        public bool Assistencias { get; set; }
        public bool Partidas { get; set; }
        public bool Amarelos { get; set; }
        public bool Vermelhos { get; set; }
    }
}
