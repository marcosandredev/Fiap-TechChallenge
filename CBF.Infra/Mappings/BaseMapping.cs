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

        builder.Property(x => x.Created)
           .IsRequired()
           .HasColumnName("Created")
           .HasColumnType("SMALLDATETIME")
           .ValueGeneratedOnAdd();

        builder.Property(x => x.Updated)
           .HasColumnName("Updated")
           .HasColumnType("SMALLDATETIME")
           .ValueGeneratedOnAddOrUpdate();
    }
}
