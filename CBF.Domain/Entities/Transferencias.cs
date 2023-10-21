﻿using CBF.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.Entities
{
    public class Transferencias : EntityBase
    {
        public long IdJogador { get; set; }
        public long IdClubeAnterior { get; set; }
        public long IdClubeNovo { get; set; }
        public DateTime DtTransferencia { get; set; }
        public DateTime DtInicioContrato { get; set; }
        public DateTime DtPrevisaoFimContrato { get; set; }
        public double VlTransferencia { get; set; }
        public Jogador Jogador { get; set; }
        public Clube ClubeAnterior { get; set; }
        public Clube ClubeNovo { get; set; }
    }
}
