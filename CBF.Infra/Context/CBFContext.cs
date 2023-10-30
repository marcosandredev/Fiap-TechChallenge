using CBF.Domain.Entities;
using CBF.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

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
    public DbSet<Temporada> Temporadas { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CBFContext).Assembly);
    }

    public override int SaveChanges()
    {
        OnBeforeSaving();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        OnBeforeSaving();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void OnBeforeSaving()
    {
        foreach (var entry in ChangeTracker.Entries<EntityBase>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CriadoEm = entry.Entity.AtualizadoEm = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.AtualizadoEm = DateTime.Now;
                    break;
                case EntityState.Deleted:
                    entry.State = EntityState.Modified;
                    entry.Entity.Ativo = false;
                    break;
            }
        }
    }
}
