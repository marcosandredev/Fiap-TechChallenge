using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;

namespace CBF.Service.Services;
public class ClubeService : IClubeService
{
    private readonly IClubeRepository _clubeRepository;

    public ClubeService(IClubeRepository clubeRepository)
    {
        _clubeRepository = clubeRepository;
    }
}
