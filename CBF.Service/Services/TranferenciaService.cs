using AutoMapper;
using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Domain.Exceptions;
using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;
using System.Data;

namespace CBF.Service.Services;
public class TranferenciaService : ITransferenciaService
{
    private readonly ITransferenciaRepository _transfRepository;

    private readonly IMapper _mapper;

    public TranferenciaService(ITransferenciaRepository transfRepository)
    {
        _transfRepository = transfRepository;
    }

    public async Task<IEnumerable<TransferenciaResponse>> BuscarTransferenciaPorIdClube(long id)
    {
        var transferencias = await _transfRepository.BuscarTransferenciasPorIdClube(id);

        if (!transferencias.Any() || transferencias == null)
            throw new NotFoundException("Transferências não encontradas!");

        return _mapper.Map<IEnumerable<TransferenciaResponse>>(transferencias);
    }

    public async Task<TransferenciaResponse> BuscarTransferenciaPorId(long id)
    {
        var response = await _transfRepository.GetByIdAsync(id) ?? throw new NotFiniteNumberException();

        return _mapper.Map<TransferenciaResponse>(response);
    }

    public async Task<TransferenciaResponse> CriarTransferenciaAsync(TransferenciaRequest request)
    {
        var transferencia = _mapper.Map<Transferencias>(request);

        var model = await _transfRepository.AddAsync(transferencia);

        return _mapper.Map<TransferenciaResponse>(model);
    }

    public async Task<TransferenciaResponse> DeletarTransferencia(long id)
    {
        var transferencia = await _transfRepository.GetByIdAsync(id) ?? throw new NotFoundException();

        await _transfRepository.DeleteAsync(transferencia);

        return _mapper.Map<TransferenciaResponse>(transferencia);
    }
}
