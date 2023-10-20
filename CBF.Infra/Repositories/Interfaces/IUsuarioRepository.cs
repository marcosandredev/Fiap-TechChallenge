using CBF.Domain.Entities;
using CBF.Infra.Repositories.Common;

namespace CBF.Infra.Repositories.Interfaces;
public interface IUsuarioRepository : IBaseRepository<Usuario>
{
    Task<Usuario> GetByEmailAsync(string email);
    Task<Usuario> GetByNomeUsuarioAsync(string nomeUsuario);
}
