using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.DTOs.Response
{
    public class EstatisticaClubeResponse
    {
        public string Temporada { get; set; }
        public string Clube { get; set; }
        public int? Gols { get; set; }
        public int? Assistencias { get; set; }
        public int? Partidas { get; set; }
        public int? Amarelos { get; set; }
        public int? Vermelhos { get; set; }
    }
}
