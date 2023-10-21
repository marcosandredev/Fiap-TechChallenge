using CBF.Domain.Entities.Enums;

namespace CBF.Domain.DTOs.Response;
public class UsuarioResponse
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string NomeUsuario { get; set; }
    public Permissao Permissao { get; set; }
}
