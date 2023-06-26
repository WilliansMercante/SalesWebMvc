using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SalesWebMvc.Dominio.Entidades.SalesWebMvc;

namespace SalesWebMvc.Infra.Data.Mappings.SalesWebMvc
{
    internal sealed class VendedorMapping : IEntityTypeConfiguration<VendedorEntity>
    {
        public void Configure(EntityTypeBuilder<VendedorEntity> builder)
        {
            builder.ToTable("TB_VENDEDOR");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_VENDEDOR");
            builder.Property(p => p.Nome).HasColumnName("NM_VENDEDOR");
            builder.Property(p => p.Email).HasColumnName("DS_EMAIL");
            builder.Property(p => p.DtNascimento).HasColumnName("DT_NASCIMENTO");
            builder.Property(p => p.Salario).HasColumnName("SALARIO");

        }
    }
}
