﻿using CBF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CBF.Infra.Mappings
{
    public class TransferenciasMapping : BaseMapping<Transferencias>
    {
        public override void Configure(EntityTypeBuilder<Transferencias> builder)
        {
            base.Configure(builder);

            builder.ToTable("Transferencias");
            builder.Property(x => x.DtTransferencia).HasConversion<string>().IsRequired();
            builder.Property(t => t.VlTransferencia).HasPrecision(18, 2);
            builder.Property(t => t.DtInicioContrato).IsRequired();
            builder.Property(t => t.IdJogador).IsRequired();
            builder.Property(t => t.IdClubeAnterior).IsRequired();
            builder.Property(t => t.IdClubeNovo).IsRequired();
            builder.Property(t => t.DtPrevisaoFimContrato).IsRequired();
            builder.HasOne(t => t.Jogador).WithMany(j => j.Transferencias).HasForeignKey(t => t.IdJogador);
            builder.HasOne(t => t.ClubeAnterior).WithMany(c => c.TransferenciasClubeAnterior).HasForeignKey(t => t.IdClubeAnterior);
            builder.HasOne(t => t.ClubeNovo)
                .WithMany(c => c.TransferenciasClubeNovo)
                .HasForeignKey(t => t.IdClubeNovo)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(t => t.Temporada)
                .WithMany()
                .HasForeignKey(t => t.IdTemporada);
        }
    }
}
