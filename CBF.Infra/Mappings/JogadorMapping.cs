using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CBF.Domain.Entities;
using CBF.Infra.Mappings;

namespace CBF.API.Configuration
{
    public class JogadorMapping : BaseMapping<Jogador>
    {

        public override void Configure(EntityTypeBuilder<Jogador> builder)
        {
            base.Configure(builder);

            builder.ToTable("Jogador");
            builder.Property(j => j.Nome).IsRequired().HasMaxLength(80);
            builder.Property(j => j.DtNascimento).IsRequired();
            builder.Property(j => j.Nacionalidade).IsRequired().HasMaxLength(30);
            builder.Property(j => j.Posicao).HasConversion<string>().IsRequired();
            builder.Property(j => j.PePreferido).HasConversion<string>().IsRequired();
            builder.Property(j => j.Peso).IsRequired().HasPrecision(5, 2);
            builder.Property(j => j.Altura).IsRequired().HasPrecision(3 , 2);
            builder.HasMany(j => j.Transferencias).WithOne(t => t.Jogador).HasForeignKey(t => t.IdJogador);
            builder.HasMany(j => j.EstatisticasJogador).WithOne(e => e.Jogador).HasForeignKey(e => e.IdJogador);
            builder.HasMany(j => j.EstatisticasJogadorClube).WithOne(ec => ec.Jogador).HasForeignKey(ec => ec.IdJogador);
            builder.HasMany(j => j.Clubes).WithOne(c => c.Jogador).HasForeignKey(c => c.IdJogador);
        }
    }
}
