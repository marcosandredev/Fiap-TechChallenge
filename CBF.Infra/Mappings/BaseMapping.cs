using CBF.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CBF.Infra.Mappings;
public class BaseMapping<T> : IEntityTypeConfiguration<T> where T : EntityBase
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Ativo)
            .IsRequired()
            .HasColumnName("Ativo");

        builder.Property(x => x.CriadoEm)
           .IsRequired()
           .HasColumnName("CriadoEm")
           .HasColumnType("SMALLDATETIME");

        builder.Property(x => x.AtualizadoEm)
           .HasColumnName("AtualizadoEm")
           .HasColumnType("SMALLDATETIME");
    }
}
