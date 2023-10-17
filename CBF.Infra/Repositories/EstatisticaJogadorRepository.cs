using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;

namespace CBF.Infra.Repositories;
public class EstatisticaJogadorRepository : BaseRepository<EstatisticaJogador>, IEstatisticaJogadorRepository
{
    public EstatisticaJogadorRepository(CBFContext context) : base(context)
    {
    }
}
