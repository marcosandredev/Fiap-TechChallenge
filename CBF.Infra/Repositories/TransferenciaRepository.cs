using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CBF.Infra.Repositories;
public class TransferenciaRepository : BaseRepository<Transferencias>, ITransferenciaRepository
{
    public TransferenciaRepository(CBFContext context) : base(context){}

    public async Task<IEnumerable<Transferencias>> BuscarTransferenciasPorIdClube(long id)
    {
        var transferenciasClube = await _context.Transferencias
            .Include(x => x.ClubeAnterior)
            .Include(x => x.ClubeNovo)
            .Include(x => x.Jogador)
            .Include(x => x.Temporada)
            .Where(transf => transf.Id == id)
            .ToListAsync();

        return transferenciasClube;
    }
}
