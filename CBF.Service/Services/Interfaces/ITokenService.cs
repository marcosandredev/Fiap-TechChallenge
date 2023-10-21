using CBF.Domain.DTOs;
using CBF.Domain.Entities;

namespace CBF.Service.Services.Interfaces
{
    public interface ITokenService
    {
        Task<string> GerarToken(LoginDTO login);
    }
}
