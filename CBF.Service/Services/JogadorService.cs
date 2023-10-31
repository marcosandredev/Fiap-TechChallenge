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
        var jogador = await _jogadorRepository.GetByIdAsync(id, x => x.Include(j => j.Clubes.Where(c => c.Id == request.Contrato.Id))) ?? throw new NotFoundException();

        var jogadorAtualizado = _mapper.Map<Jogador>(request);

        jogador.Peso = jogadorAtualizado.Peso;
        jogador.Nome = jogadorAtualizado.Nome;
        jogador.PePreferido = jogadorAtualizado.PePreferido;
        jogador.Posicao = jogadorAtualizado.Posicao;

        if (jogador.Clubes.Count == 0)
        {
            jogador.Clubes = new List<ClubeJogador>()
            {
                new ClubeJogador()
                {
                    IdClube = request.Contrato.IdClube,
                    DtInicioContrato = request.Contrato.DtInicioContrato,
                    DtFimContrato = request.Contrato.DtFimContrato,
                    Salario = request.Contrato.Salario
                }
            };
        }
        else
        {
            jogador.Clubes.FirstOrDefault().IdClube = request.Contrato.IdClube;
            jogador.Clubes.FirstOrDefault().Salario = request.Contrato.Salario;
            jogador.Clubes.FirstOrDefault().DtInicioContrato = request.Contrato.DtInicioContrato;
            jogador.Clubes.FirstOrDefault().DtFimContrato = request.Contrato.DtFimContrato;
        }

        var model = await _jogadorRepository.UpdateAsync(jogador);

        return _mapper.Map<JogadorResponse>(model);
    }

    public async Task<JogadorResponse> BuscaJogadorPorIdAsync(long id)
    {
        var jogador = await _jogadorRepository.GetByIdAsync(id, x => x.Include(x => x.Clubes).ThenInclude(x => x.Clube)) ?? throw new NotFoundException();

        return _mapper.Map<JogadorResponse>(jogador);

    }

    public async Task<IEnumerable<JogadorResponse>> BuscaJogadoresAsync()
    {
        var jogador = await _jogadorRepository.GetAllAsync(include: x => x.Include(x => x.Clubes).ThenInclude(x => x.Clube));

        return _mapper.Map<IEnumerable<JogadorResponse>>(jogador);

    }

    public async Task<IEnumerable<JogadorResponse>> BuscarJogadoresPorNacionalidadeAsync(string nacionalidade)
    {
        var model = await _jogadorRepository.BuscarJogadoresPorNacionalidadeAsync(nacionalidade);

        if (model == null || !model.Any())
            throw new NotFoundException(ExceptionMessage.Jogadores_Nasc_Not_Found);

        return _mapper.Map<IEnumerable<JogadorResponse>>(model);
    }

    public async Task<JogadorResponse> CadastrarJogadorAsync(JogadorRequest request)
    {
        var jogador = _mapper.Map<Jogador>(request);

        bool exits = await _jogadorRepository.ExistAsync(j => j.Nome == jogador.Nome && j.DtNascimento == jogador.DtNascimento);

        if (exits)
            throw new BadRequestException(ExceptionMessage.Jogador_Already_Exists);

        jogador.Clubes = new List<ClubeJogador>()
        {
            new ClubeJogador()
            {
                IdClube = request.Contrato.IdClube,
                DtInicioContrato = request.Contrato.DtInicioContrato,
                DtFimContrato = request.Contrato.DtFimContrato,
                Salario = request.Contrato.Salario
            }
        };

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
