using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;

namespace CBF.Service.Services.Interfaces;
public interface IClubeService
{
    Task<IEnumerable<ClubeResponse>> BuscarClubesPorNomeAsync(string nome);

    Task<ClubeResponse> BuscarClubesPorIdAsync(long id);

    Task<ClubeResponse> CadastrarClubeAsync(ClubeRequest request);

    Task<ClubeResponse> AtualizarClubeAsync(long id, ClubeUpdateRequest request);

    Task<ClubeResponse> DeletarClubeAsync(long id);
}
