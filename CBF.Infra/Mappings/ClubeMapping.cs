using CBF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Infra.Mappings
{
    public class ClubeMapping : BaseMapping<Clube>
    {
        public override void Configure(EntityTypeBuilder<Clube> builder)
        {
            base.Configure(builder);

            builder.ToTable("Clube");
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(80);
            builder.Property(c => c.DtFundacao).IsRequired();
            builder.Property(c => c.Pais).IsRequired().HasMaxLength(80);
            builder.HasMany(c => c.TransferenciasClubeAnterior).WithOne(t => t.ClubeAnterior).HasForeignKey(t => t.IdClubeAnterior);
            builder.HasMany(c => c.TransferenciasClubeNovo).WithOne(t => t.ClubeNovo).HasForeignKey(t => t.IdClubeNovo);
            builder.HasMany(c => c.EstatisticasJogadorClube).WithOne(e => e.Clube).HasForeignKey(e => e.IdClube);
            builder.HasMany(c => c.ClubesJogadores).WithOne(e => e.Clube).HasForeignKey(e => e.IdClube);

        }
    }
}
