using Microsoft.EntityFrameworkCore;
using CBF.Domain.Entities;

namespace CBF.Infra.Context;
public class CBFContext : DbContext
{
    public CBFContext(DbContextOptions<CBFContext> options) : base(options) { }

    public DbSet<Jogador> Jogadores { get; set; }
    public DbSet<Clube> Clubes { get; set; }
    public DbSet<Transferencias> Transferencias { get; set; }
    public DbSet<EstatisticaJogador> EstatisticasJogador { get; set; }
    public DbSet<EstatisticaJogadorClube> EstatisticasJogadorClube { get; set; }
    public DbSet<ClubeJogador> ClubesJogadores { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CBFContext).Assembly);
    }
}
