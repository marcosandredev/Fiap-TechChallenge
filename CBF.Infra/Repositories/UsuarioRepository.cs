using CBF.Domain.Entities;
using CBF.Infra.Context;
using CBF.Infra.Repositories.Common;
using CBF.Infra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CBF.Infra.Repositories;
public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(CBFContext context) : base(context)
    {
    }

    public async Task<Usuario> GetByEmailAsync(string email)
    {
        return await _context.Usuarios.FirstOrDefaultAsync(x => x.Email == email);
    }

    public async Task<Usuario> GetByNomeUsuarioAsync(string nomeUsuario)
    {
        return await _context.Usuarios.FirstOrDefaultAsync(x => x.NomeUsuario == nomeUsuario);
    }
}
