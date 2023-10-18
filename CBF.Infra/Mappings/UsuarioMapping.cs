using CBF.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Infra.Mappings
{
    public class UsuarioMapping : BaseMapping<Usuario>
    {
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            base.Configure(builder);
            builder.Property(u => u.Login).HasMaxLength(30).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(12).IsRequired();
            builder.Property(u => u.Permissao).HasConversion<string>().IsRequired();

        }
    }
}
