using CBF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CBF.Infra.Mappings;
public class TemporadaMapping : BaseMapping<Temporada>
{
    public override void Configure(EntityTypeBuilder<Temporada> builder)
    {
        base.Configure(builder);

        builder.ToTable("Temporada");

        builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Inicio).IsRequired();
        builder.Property(x => x.Fim).IsRequired();
    }
}
