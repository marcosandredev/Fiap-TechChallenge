using CBF.Domain.DTOs;
using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;
using SecureIdentity.Password;

namespace CBF.Service.Services;
public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly ITokenService _tokenService;

    public UsuarioService(IUsuarioRepository usuarioRepository, ITokenService tokenService)
    {
        _usuarioRepository = usuarioRepository;
        _tokenService = tokenService;
    }

    public async Task<string> GerarToken(LoginDTO login)
    {

        var usuario = await _usuarioRepository.GetByNomeUsuarioAsync(login.Email);

        if (usuario is null)
            return null;

        var senhaCorreta = PasswordHasher.Verify(usuario.SenhaCriptografa, login.Senha);

        if (!senhaCorreta)
            return null;

        return _tokenService.GetToken(usuario);
    }
}
