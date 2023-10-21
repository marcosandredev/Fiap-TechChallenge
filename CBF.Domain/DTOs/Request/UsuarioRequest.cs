using CBF.Domain.Entities.Enums;

namespace CBF.Domain.DTOs.Request;
public class UsuarioRequest
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string NomeUsuario { get; set; }
    public string Senha { get; set; }
    public int Permissao { get; set; }
}
