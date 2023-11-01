using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Domain.Exceptions;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CBF.Infra.Repositories;
public class JogadorRepository : BaseRepository<Jogador>, IJogadorRepository
{
    public JogadorRepository(CBFContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Jogador>> BuscarJogadoresPorNacionalidadeAsync(string nacionalidade)
    {
        var jogadoresFiltrados = await _context.Jogadores
            .Include(x => x.Transferencias).ThenInclude(x => x.ClubeNovo)
            .Include(x => x.Transferencias).ThenInclude(x => x.ClubeAnterior)
            .Include(x => x.Transferencias).ThenInclude(x => x.Temporada)
            .Where(j => j.Nacionalidade.Equals(nacionalidade))
            .ToListAsync();

        return jogadoresFiltrados;
    }
}