using CBF.Domain.Entities.Common;
using CBF.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public Permissao Permissao { get; set; }

        public Usuario()
        {

        }
    }
}
