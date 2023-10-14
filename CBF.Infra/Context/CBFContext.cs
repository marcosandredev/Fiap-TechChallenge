using Microsoft.EntityFrameworkCore;

namespace CBF.Infra.Context;
public class CBFContext : DbContext
{
    public CBFContext(DbContextOptions<CBFContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CBFContext).Assembly);
    }
}
