using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;

namespace CBF.Service.Services.Interfaces;
public interface ITransferenciaService
{
    Task<TransferenciaResponse> CriarTransferenciaAsync(TransferenciaRequest request);
    Task<TransferenciaResponse> BuscarTransferenciaPorId(long id);
    Task<TransferenciaResponse> DeletarTransferencia(long id);
    Task<IEnumerable<TransferenciaResponse>> BuscarTransferenciaPorIdClube(long id);
    Task<TransferenciaResponse> AtualizarTransferenciaAsync(long id, TransferenciaRequest request);
}
