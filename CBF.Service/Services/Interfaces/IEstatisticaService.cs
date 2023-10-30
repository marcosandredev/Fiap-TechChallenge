using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Service.Services.Interfaces
{
    public interface IEstatisticaService
    {
        Task<EstatisticaJogadorResponse> CadastrarEstatisticaJogadorAsync(EstatisticaJogadorRequest request);

        Task<EstatisticaJogadorClubeResponse> CadastrarEstatisticaJogadorClubeAsync(EstatisticaJogadorClubeRequest request);

        Task<IEnumerable<EstatisticaResponse>> GetJogadoresGolsAsync(long idTemporada);

        Task<IEnumerable<EstatisticaResponse>> GetJogadoresVermelhosAsync(long idTemporada);

        Task<IEnumerable<EstatisticaResponse>> GetJogadoresAmarelosAsync(long idTemporada);

        Task<IEnumerable<EstatisticaResponse>> GetJogadoresAssistenciasAsync(long idTemporada);

        Task<IEnumerable<EstatisticaResponse>> GetJogadoresPartidasAsync(long idTemporada);

        Task<IEnumerable<EstatisticaClubeResponse>> GetEstatisticasClubesTemporada(EstatisticasClubesRequest request);
    }
}
