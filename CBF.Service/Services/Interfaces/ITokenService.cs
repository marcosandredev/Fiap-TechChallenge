using CBF.Domain.Entities;

namespace CBF.Service.Services.Interfaces
{
    public interface ITokenService
    {
        string GetToken(Usuario usuario);
    }
}
