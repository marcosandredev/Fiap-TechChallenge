using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;

namespace CBF.Service.Services;
public class TranferenciaService : ITransferenciaService
{
    private readonly ITransferenciaRepository _transfRepository;

    public TranferenciaService(ITransferenciaRepository transfRepository)
    {
        _transfRepository = transfRepository;
    }
}
