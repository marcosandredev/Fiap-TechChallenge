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
    public class EstatisticaJogadorClubeMapping : BaseMapping<EstatisticaJogadorClube>
    {

        public override void Configure(EntityTypeBuilder<EstatisticaJogadorClube> builder)
        {
            base.Configure(builder);

            builder.ToTable("EstatisticaJogadorClube");
            builder.Property(e => e.IdJogador).IsRequired();
            builder.Property(e => e.IdClube).IsRequired();
            builder.Property(e => e.Partidas).IsRequired();
            builder.Property(e => e.Gols).IsRequired();
            builder.Property(e => e.Assistencias).IsRequired();
            builder.Property(e => e.Amarelos).IsRequired();
            builder.Property(e => e.Vermelhos).IsRequired();
            builder.HasOne(e => e.Jogador).WithMany(j => j.EstatisticasJogadorClube).HasForeignKey(e => e.IdJogador);
            builder.HasOne(e => e.Clube).WithMany(j => j.EstatisticasJogadorClube).HasForeignKey(e => e.IdClube);
            builder.HasOne(t => t.Temporada)
                .WithMany()
                .HasForeignKey(t => t.IdTemporada);
        }
    }
}
