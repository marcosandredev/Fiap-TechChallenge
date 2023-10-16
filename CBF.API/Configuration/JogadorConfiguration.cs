using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CBF.Domain.Entities;

namespace CBF.API.Configuration
{
    public class JogadorConfiguration : IEntityTypeConfiguration<Jogador>
    {

        public void Configure(EntityTypeBuilder<Jogador> builder)
        {
            builder.ToTable("Jogador");
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Nome).IsRequired().HasMaxLength(80);
            builder.Property(j => j.DtNascimento).IsRequired();
            builder.Property(j => j.Nacionalidade).IsRequired().HasMaxLength(30);
            builder.Property(j => j.Posicao).IsRequired().HasMaxLength(2);
            builder.Property(j => j.Peso).IsRequired();
        }
    }
}
