using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SalesWebMvc.Dominio.Entidades.SalesWebMvc;

namespace SalesWebMvc.Infra.Data.Mappings.SalesWebMvc
{
    internal sealed class HistoricoVendasMapping : IEntityTypeConfiguration<HistoricoVendasEntity>
    {
        public void Configure(EntityTypeBuilder<HistoricoVendasEntity> builder)
        {
            builder.ToTable("TB_HISTORICO_VENDA");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_HISTORICO_VENDA");
            builder.Property(p => p.DtVenda).HasColumnName("DT_VENDA");


        }
    }
}
