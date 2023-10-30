using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;

namespace CBF.Service.Services.Interfaces;
public interface ITemporadaService
{
    Task<TemporadaResponse> CreateAsync(TemporadaRequest request);
    Task<TemporadaResponse> UpdateAsync(long id, TemporadaRequest request);
    Task<IEnumerable<TemporadaResponse>> GetAllAsync();
}
