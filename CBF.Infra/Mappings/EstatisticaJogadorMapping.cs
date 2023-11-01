using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CBF.Infra.Mappings
{
    public class EstatisticaJogadorMapping : BaseMapping<EstatisticaJogador>
    {
        public override void Configure(EntityTypeBuilder<EstatisticaJogador> builder)
        {
            base.Configure(builder);

            builder.ToTable("EstatisticaJogador");
            builder.HasOne(e => e.Jogador).WithMany(j => j.EstatisticasJogador).HasForeignKey(e => e.IdJogador);
            builder.Property(e => e.Partidas).IsRequired();
            builder.Property(e => e.Gols).IsRequired();
            builder.Property(e => e.Assistencias).IsRequired();
            builder.Property(e => e.Amarelos).IsRequired();
            builder.Property(e => e.Vermelhos).IsRequired();
            builder.HasOne(t => t.Temporada)
                .WithMany()
                .HasForeignKey(t => t.IdTemporada);

        }
    }
}
