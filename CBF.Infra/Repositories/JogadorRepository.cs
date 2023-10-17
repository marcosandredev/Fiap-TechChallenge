using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;

namespace CBF.Infra.Repositories;
public class JogadorRepository : BaseRepository<Jogador>, IJogadorRepository
{
    public JogadorRepository(CBFContext context) : base(context)
    {
    }
}
