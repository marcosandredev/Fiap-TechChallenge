using AutoMapper;
using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;

namespace CBF.Service.Services;
public class TranferenciaService : ITransferenciaService
{
    private readonly ITransferenciaRepository _transfRepository;

    private readonly IMapper _mapper;

    public TranferenciaService(ITransferenciaRepository transfRepository)
    {
        _transfRepository = transfRepository;
    }

    public async Task<TransferenciaResponse> CriarTransferenciaAsync(TransferenciaRequest request)
    {
        var transferencia = _mapper.Map<Transferencias>(request);

        var model = await _transfRepository.AddAsync(transferencia);

        return _mapper.Map<TransferenciaResponse>(model);
    }
}
