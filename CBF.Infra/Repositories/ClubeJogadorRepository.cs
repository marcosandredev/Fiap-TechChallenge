using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;

namespace CBF.Infra.Repositories;
public class ClubeJogadorRepository : BaseRepository<ClubeJogador>, IClubeJogadorRepository
{
    public ClubeJogadorRepository(CBFContext context) : base(context)
    {
    }
}
