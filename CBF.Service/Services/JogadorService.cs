using AutoMapper;
using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Domain.Exceptions;
using CBF.Infra.Repositories.Interfaces;
using CBF.Service.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CBF.Service.Services;
public class JogadorService : IJogadorService
{
    private readonly IJogadorRepository _jogadorRepository;
    private readonly IMapper _mapper;

    public JogadorService(IJogadorRepository jogadorRepository, IMapper mapper)
    {
        _jogadorRepository = jogadorRepository;
        _mapper = mapper;
    }

    public async Task<JogadorResponse> AtualizarJogadorAsync(long id, JogadorUpdateRequest request)
    {
        var jogador = await _jogadorRepository.GetByIdAsync(id) ?? throw new NotFoundException();

        _mapper.Map(request, jogador);

        var model = await _jogadorRepository.UpdateAsync(jogador);

        return _mapper.Map<JogadorResponse>(model);
    }

    public async Task<JogadorResponse> BuscaJogadorPorIdAsync(long id)
    {
        var jogador = await _jogadorRepository.GetByIdAsync(id, x => x.Include(x => x.Transferencias).ThenInclude(x => x.ClubeNovo)
                                                                                           .Include(x => x.Transferencias).ThenInclude(x => x.ClubeAnterior)
                                                                                           .Include(x => x.Transferencias).ThenInclude(x => x.Temporada)
                                                                                           ) ?? throw new NotFoundException();

        return _mapper.Map<JogadorResponse>(jogador);

    }

    public async Task<IEnumerable<JogadorResponse>> BuscaJogadoresAsync()
    {
        var jogador = await _jogadorRepository.GetAllAsync(include: x => x.Include(x => x.Transferencias).ThenInclude(x => x.ClubeNovo)
                                                                                           .Include(x => x.Transferencias).ThenInclude(x => x.ClubeAnterior)
                                                                                           .Include(x => x.Transferencias).ThenInclude(x => x.Temporada)
                                                                                           ) ?? throw new NotFoundException();
        return _mapper.Map<IEnumerable<JogadorResponse>>(jogador);

    }

    public async Task<IEnumerable<JogadorResponse>> BuscarJogadoresPorNacionalidadeAsync(string nacionalidade)
    {
        var model = await _jogadorRepository.BuscarJogadoresPorNacionalidadeAsync(nacionalidade);

        return _mapper.Map<IEnumerable<JogadorResponse>>(model);
    }

    public async Task<JogadorResponse> CadastrarJogadorAsync(JogadorRequest request)
    {
        var jogador = _mapper.Map<Jogador>(request);

        bool exits = await _jogadorRepository.ExistAsync(j => j.Nome == jogador.Nome && j.DtNascimento == jogador.DtNascimento);

        if (exits)
            throw new BadRequestException(ExceptionMessage.Jogador_Already_Exists);

        var model = await _jogadorRepository.AddAsync(jogador);

        return _mapper.Map<JogadorResponse>(model);
    }

    public async Task<JogadorResponse> DeletarJogadorAsync(long id)
    {
        var jogador = await _jogadorRepository.GetByIdAsync(id) ?? throw new NotFoundException();

        await _jogadorRepository.DeleteAsync(jogador);

        return _mapper.Map<JogadorResponse>(jogador);

    }
}
