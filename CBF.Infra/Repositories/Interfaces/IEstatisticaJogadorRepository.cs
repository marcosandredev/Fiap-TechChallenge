using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
using CBF.Domain.Entities;
using CBF.Infra.Repositories.Common;

namespace CBF.Infra.Repositories.Interfaces;
public interface IEstatisticaJogadorRepository : IBaseRepository<EstatisticaJogador>
{
    Task<IEnumerable<EstatisticaResponse>> GetJogadorGolsAsync(long idTemporada);

    Task<IEnumerable<EstatisticaResponse>> GetJogadorVermelhosAsync(long idTemporada);

    Task<IEnumerable<EstatisticaResponse>> GetJogadorAmarelosAsync(long idTemporada);

    Task<IEnumerable<EstatisticaResponse>> GetJogadorAssistenciasAsync(long idTemporada);

    Task<IEnumerable<EstatisticaResponse>> GetJogadorPartidasAsync(long idTemporada);

    Task<IEnumerable<EstatisticaClubeResponse>> GetEstatisticasClubesTemporada(EstatisticasClubesRequest request);

}
