using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;

namespace CBF.Infra.Repositories;
public class TransferenciaRepository : BaseRepository<Transferencias>, ITransferenciaRepository
{
    public TransferenciaRepository(CBFContext context) : base(context)
    {
    }
}
