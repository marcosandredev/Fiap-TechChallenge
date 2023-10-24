using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
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
        var jogadoresFiltrados = await _context.Jogadores.Where(j => j.Nacionalidade.Equals(nacionalidade)).ToListAsync();

        return jogadoresFiltrados;
    }
}