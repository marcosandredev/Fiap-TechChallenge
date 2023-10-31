using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CBF.Infra.Repositories;
public class EstatisticaJogadorRepository : BaseRepository<EstatisticaJogador>, IEstatisticaJogadorRepository
{
    public EstatisticaJogadorRepository(CBFContext context) : base(context)
    {
    }

    public async Task<IEnumerable<EstatisticaClubeResponse>> GetEstatisticasClubesTemporada(EstatisticasClubesRequest request)
    {
        var consulta = _context.EstatisticasJogadorClube
        .Join(_context.Clubes, e => e.IdClube, c => c.Id, (e, c) => new { e, c })
        .Join(_context.Temporadas, ec => ec.e.IdTemporada, t => t.Id, (ec, t) => new { ec.e, ec.c, NomeTemporada = t.Nome })
         .Where(ec => ec.e.IdTemporada == request.idTemporada)
        .GroupBy(ec => new { ec.c.Nome, ec.NomeTemporada })
        .Select(grupo => new EstatisticaClubeResponse
        {
            Temporada = grupo.Key.NomeTemporada,
            Clube = grupo.Key.Nome,
            Gols = request.Gols? grupo.Sum(ec => ec.e.Gols) : 0,
            Partidas = request.Partidas? grupo.Sum(ec => ec.e.Partidas) : 0,
            Assistencias = request.Assistencias? grupo.Sum(ec => ec.e.Assistencias) : 0,
            Vermelhos = request.Vermelhos? grupo.Sum(ec => ec.e.Vermelhos) : 0,
            Amarelos = request.Amarelos? grupo.Sum(ec => ec.e.Amarelos) : 0

        });

        return await consulta.ToListAsync();
    }

    public async Task<IEnumerable<EstatisticaResponse>> GetJogadorAmarelosAsync(long idTemporada)
    {
        var consulta = from ej in _context.EstatisticasJogador
                       join j in _context.Jogadores on ej.IdJogador equals j.Id
                       where ej.IdTemporada == idTemporada && j.Ativo == true
                       orderby ej.Amarelos descending
                       select new EstatisticaResponse
                       {
                           Id = j.Id,
                           Nome = j.Nome,
                           Agrupador = ej.Gols.ToString()
                       };

        return await consulta.ToListAsync();
    }

    public async Task<IEnumerable<EstatisticaResponse>> GetJogadorAssistenciasAsync(long idTemporada)
    {
        var consulta = from ej in _context.EstatisticasJogador
                       join j in _context.Jogadores on ej.IdJogador equals j.Id
                       where ej.IdTemporada == idTemporada && j.Ativo == true
                       orderby ej.Assistencias descending
                       select new EstatisticaResponse
                       {
                           Id = j.Id,
                           Nome = j.Nome,
                           Agrupador = ej.Gols.ToString()
                       };

        return await consulta.ToListAsync();
    }

    public async Task<IEnumerable<EstatisticaResponse>> GetJogadorGolsAsync(long idTemporada)
    {
        var consulta = from ej in _context.EstatisticasJogador
                       join j in _context.Jogadores on ej.IdJogador equals j.Id
                       where ej.IdTemporada == idTemporada && j.Ativo == true
                       orderby ej.Gols descending
                       select new EstatisticaResponse
                       {
                           Id = j.Id,
                           Nome = j.Nome,
                           Agrupador = ej.Gols.ToString()
                       };

        return await consulta.ToListAsync();
    }

    public async Task<IEnumerable<EstatisticaResponse>> GetJogadorPartidasAsync(long idTemporada)
    {
        var consulta = from ej in _context.EstatisticasJogador
                       join j in _context.Jogadores on ej.IdJogador equals j.Id
                       where ej.IdTemporada == 1 && j.Ativo == true
                       orderby ej.Partidas descending
                       select new EstatisticaResponse
                       {
                           Id = j.Id,
                           Nome = j.Nome,
                           Agrupador = ej.Gols.ToString()
                       };


        return await consulta.ToListAsync();
    }

    public async Task<IEnumerable<EstatisticaResponse>> GetJogadorVermelhosAsync(long idTemporada)
    {
        var consulta = from ej in _context.EstatisticasJogador
                       join j in _context.Jogadores on ej.IdJogador equals j.Id
                       where ej.IdTemporada == idTemporada && j.Ativo == true
                       orderby ej.Vermelhos descending
                       select new EstatisticaResponse
                       {
                           Id = j.Id,
                           Nome = j.Nome,
                           Agrupador = ej.Gols.ToString()
                       };

        return await consulta.ToListAsync();
    }
}
