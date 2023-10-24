using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Infra.Repositories.Common;

namespace CBF.Infra.Repositories.Interfaces;
public interface IJogadorRepository : IBaseRepository<Jogador>
{
    Task<IEnumerable<Jogador>> BuscarJogadoresPorNacionalidadeAsync(string nacionalidade);
}
