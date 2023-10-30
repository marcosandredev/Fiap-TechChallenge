using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;

namespace CBF.Service.Services.Interfaces;
public interface ITransferenciaService
{
    Task<TransferenciaResponse> CriarTransferenciaAsync(TransferenciaRequest request);
}
