using AutoMapper;
using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Domain.Exceptions;
using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;

namespace CBF.Service.Services;
public class ClubeService : IClubeService
{
    private readonly IClubeRepository _clubeRepository;

    private readonly IMapper _mapper;

    public ClubeService(IClubeRepository clubeRepository, IMapper mapper)
    {
        _clubeRepository = clubeRepository;
        _mapper = mapper;
    }

    public async Task<ClubeResponse> AtualizarClubeAsync(long id, ClubeUpdateRequest request)
    {
        var clube = await _clubeRepository.GetByIdAsync(id) ?? throw new NotFoundException();

        var clubeAtualizado = _mapper.Map<Clube>(request);

        clube.Nome = clubeAtualizado.Nome;

        var model = await _clubeRepository.UpdateAsync(clube);

        return _mapper.Map<ClubeResponse>(model);
    }

    public async Task<IEnumerable<ClubeResponse>> BuscarClubesPorNomeAsync(string nome)
    {
        var model = await _clubeRepository.BuscarClubesPorNomeAsync(nome);

        if (model == null || !model.Any())
            throw new NotFoundException(ExceptionMessage.Clubes_Not_Found);

        return _mapper.Map<IEnumerable<ClubeResponse>>(model);
    }

    public async Task<ClubeResponse> BuscarClubesPorIdAsync(long id)
    {
        var clube = await _clubeRepository.GetByIdAsync(id) ?? throw new NotFoundException();

        return _mapper.Map<ClubeResponse>(clube);
    }

    public async Task<ClubeResponse> CadastrarClubeAsync(ClubeRequest request)
    {
        var clube = _mapper.Map<Clube>(request);

        bool exits = await _clubeRepository.ExistAsync(c => c.Nome == clube.Nome && c.DtFundacao == clube.DtFundacao);

        if (exits) throw new AlreadyExistsExceptionClube();

        var model = await _clubeRepository.AddAsync(clube);

        return _mapper.Map<ClubeResponse>(model);
    }

    public async Task<ClubeResponse> DeletarClubeAsync(long id)
    {
        var clube = await _clubeRepository.GetByIdAsync(id) ?? throw new NotFoundException();

        await _clubeRepository.DeleteAsync(clube);

        return _mapper.Map<ClubeResponse>(clube);
    }
}
