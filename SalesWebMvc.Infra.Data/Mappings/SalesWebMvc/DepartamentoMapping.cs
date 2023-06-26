using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SalesWebMvc.Dominio.Entidades.SalesWebMvc;

namespace SalesWebMvc.Infra.Data.Mappings.SalesWebMvc
{

    internal sealed class DepartamentoMapping : IEntityTypeConfiguration<DepartamentoEntity>
    {
        public void Configure(EntityTypeBuilder<DepartamentoEntity> builder)
        {
            builder.ToTable("TB_DEPARTAMENTO");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_DEPARTAMENTO");
            builder.Property(p => p.Nome).HasColumnName("NM_DEPARTAMENTO");
    

        }
    }
}
