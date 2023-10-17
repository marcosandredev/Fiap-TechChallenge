using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;

namespace CBF.Infra.Repositories;
public class EstatisticaJogadorClubeRepository : BaseRepository<EstatisticaJogadorClube>, IEstatisticaJogadorClubeRepository
{
    public EstatisticaJogadorClubeRepository(CBFContext context) : base(context)
    {
    }
}
