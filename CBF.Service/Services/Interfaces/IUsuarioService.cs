using CBF.Domain.DTOs;
using CBF.Domain.DTOs.Request;
using CBF.Domain.DTOs.Response;

namespace CBF.Service.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioResponse> CreateAsync(UsuarioRequest request);
        Task<UsuarioResponse> GetByIdAsync(long id);
        Task<UsuarioResponse> GetUsuarioByEmail(string email);
    }
}
