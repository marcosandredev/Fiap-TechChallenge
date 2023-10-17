using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;

namespace CBF.Service.Services;
public class JogadorService : IJogadorService
{
    private readonly IJogadorRepository _jogadorRepository;

    public JogadorService(IJogadorRepository jogadorRepository)
    {
        _jogadorRepository = jogadorRepository;
    }
}
