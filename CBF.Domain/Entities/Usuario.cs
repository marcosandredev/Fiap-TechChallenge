using CBF.Domain.Entities.Common;
using CBF.Domain.Entities.Enums;

namespace CBF.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public string Nome { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string SenhaCriptografa { get; set; }
        public Permissao Permissao { get; set; }
        public Usuario()
        {

        }
    }
}
