using AutoMapper;
using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Domain.Exceptions;
using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;

namespace CBF.Service.Services;
public class TemporadaService : ITemporadaService
{
    private readonly ITemporadaRepository _temporadaRepository;
    private readonly IMapper _mapper;

    public TemporadaService(ITemporadaRepository temporadaRepository, IMapper mapper)
    {
        _temporadaRepository = temporadaRepository;
        _mapper = mapper;
    }

    public async Task<TemporadaResponse> CreateAsync(TemporadaRequest request)
    {
        await ValidarSeJaHaTemporadaNoPeriodoInformado(request);

        var temporada = _mapper.Map<Temporada>(request);

        var model = await _temporadaRepository.AddAsync(temporada);

        return _mapper.Map<TemporadaResponse>(model);
    }

    public async Task<TemporadaResponse> UpdateAsync(long id, TemporadaRequest request)
    {
        await ValidarSeJaHaTemporadaNoPeriodoInformado(request);

        var temporada = await _temporadaRepository.GetByIdAsync(id) ?? throw new NotFoundException();

        _mapper.Map(request, temporada);

        var model = await _temporadaRepository.UpdateAsync(temporada);

        return _mapper.Map<TemporadaResponse>(model);
    }

    public async Task<IEnumerable<TemporadaResponse>> GetAllAsync()
    {
        var temporadas = await _temporadaRepository.GetAllAsync();

        return _mapper.Map<IEnumerable<TemporadaResponse>>(temporadas);
    }

    private async Task ValidarSeJaHaTemporadaNoPeriodoInformado(TemporadaRequest request)
    {
        var temporadas = await _temporadaRepository.GetAllAsync(x => x.Inicio.Year == request.Inicio.Year || x.Fim.Year == request.Fim.Year);

        if (temporadas.Any())
            throw new BadRequestException(ExceptionMessage.Season_Already_Exist);
    }
}
