using CBF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CBF.Infra.Mappings
{
    public class ClubeJogadorMapping : BaseMapping<ClubeJogador>
    {
        public override void Configure(EntityTypeBuilder<ClubeJogador> builder)
        {
            base.Configure(builder);
            builder.ToTable("ClubeJogador");
            builder.Property(cj => cj.IdJogador).IsRequired();
            builder.Property(cj => cj.IdClube).IsRequired();
            builder.Property(cj => cj.DtInicioContrato).IsRequired();
            builder.Property(cj => cj.DtFimContrato).IsRequired(false);
            builder.Property(cj => cj.Salario).HasPrecision(18,2).IsRequired();
            builder.HasOne(cj => cj.Jogador).WithMany(j => j.Clubes).HasForeignKey( cj => cj.IdJogador );
            builder.HasOne(cj => cj.Clube).WithMany(c => c.ClubesJogadores).HasForeignKey(cj => cj.IdClube);
        }
    }
}
