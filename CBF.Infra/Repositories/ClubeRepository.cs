using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;

namespace CBF.Infra.Repositories;
public class ClubeRepository : BaseRepository<Clube>, IClubeRepository
{
    public ClubeRepository(CBFContext context) : base(context)
    {
    }
}
