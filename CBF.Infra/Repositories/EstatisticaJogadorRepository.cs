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
                           Agrupador = ej.Amarelos.ToString()
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
                           Agrupador = ej.Assistencias.ToString()
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
                       where ej.IdTemporada == idTemporada && j.Ativo == true
                       orderby ej.Partidas descending
                       select new EstatisticaResponse
                       {
                           Id = j.Id,
                           Nome = j.Nome,
                           Agrupador = ej.Partidas.ToString()
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
                           Agrupador = ej.Vermelhos.ToString()
                       };

        return await consulta.ToListAsync();
    }
}
