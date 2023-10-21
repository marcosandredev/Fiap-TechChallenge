using AutoMapper;
using CBF.Domain.DTOs;
using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Domain.Exceptions;
using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;
using SecureIdentity.Password;

namespace CBF.Service.Services;
public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly ITokenService _tokenService;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepository usuarioRepository, ITokenService tokenService, IMapper mapper)
    {
        _usuarioRepository = usuarioRepository;
        _tokenService = tokenService;
        _mapper = mapper;
    }

    public async Task<UsuarioResponse> CreateAsync(UsuarioRequest request)
    {
        var usuario = _mapper.Map<Usuario>(request);

        usuario.SenhaCriptografa = PasswordHasher.Hash(usuario.SenhaCriptografa);

        var model = await _usuarioRepository.AddAsync(usuario);

        return _mapper.Map<UsuarioResponse>(model);
    }

    public async Task<UsuarioResponse> GetByIdAsync(long id)
    {
        var model = await _usuarioRepository.GetByIdAsync(id) ?? throw new NotFoundException();

        return _mapper.Map<UsuarioResponse>(model);
    }

    public async Task<UsuarioResponse> GetUsuarioByEmail(string email)
    {
        var model = await _usuarioRepository.GetByEmailAsync(email) ?? throw new NotFoundException();

        return _mapper.Map<UsuarioResponse>(model);
    }

    
}
