using CBF.Domain.Entities;
using CBF.Infra.Repositories.Common;

namespace CBF.Infra.Repositories.Interfaces;
public interface IClubeRepository : IBaseRepository<Clube>
{
        Task<IEnumerable<Clube>> BuscarClubesPorNomeAsync(string nome);
}
