using CBF.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CBF.Infra.Mappings
{
    public class UsuarioMapping : BaseMapping<Usuario>
    {
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            base.Configure(builder);
            builder.Property(u => u.Nome).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(80).IsRequired();
            builder.Property(u => u.NomeUsuario).HasMaxLength(30).IsRequired();
            builder.Property(u => u.SenhaCriptografa).HasMaxLength(20).IsRequired();
            builder.Property(u => u.Permissao).HasConversion<string>().IsRequired();

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.NomeUsuario).IsUnique();

        }
    }
}
