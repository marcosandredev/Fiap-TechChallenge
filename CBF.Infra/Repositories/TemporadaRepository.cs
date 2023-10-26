using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;

namespace CBF.Infra.Repositories;
public class TemporadaRepository : BaseRepository<Temporada>, ITemporadaRepository
{
    public TemporadaRepository(CBFContext context) : base(context)
    {
    }
}
