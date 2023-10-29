using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CBF.Infra.Repositories;
public class ClubeRepository : BaseRepository<Clube>, IClubeRepository
{
    public ClubeRepository(CBFContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Clube>> BuscarClubesPorNomeAsync(string nome)
    {
        var clubesFiltrados = await _context.Clubes.Where(c => c.Nome.Equals(nome)).ToListAsync();

        return clubesFiltrados;
    }
}
