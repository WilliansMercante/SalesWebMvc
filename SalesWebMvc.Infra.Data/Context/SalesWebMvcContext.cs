using Microsoft.EntityFrameworkCore;

using SalesWebMvc.Dominio;
using SalesWebMvc.Dominio.Entidades.SalesWebMvc;
using SalesWebMvc.Infra.Data.Mappings.SalesWebMvc;

namespace SalesWebMvc.Infra.Data.Context
{
    public sealed class SalesWebMvcContext : DbContext, IUnitOfWork<SalesWebMvcContext>
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : base(options)
        {

        }

        public DbSet<VendedorEntity> Vendedor { get; set; }
        public DbSet<DepartamentoEntity> Departamento { get; set; }
        public DbSet<HistoricoVendaEntity> HistoricoVendas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VendedorMapping());
            modelBuilder.ApplyConfiguration(new DepartamentoMapping());
            modelBuilder.ApplyConfiguration(new HistoricoVendaMapping());
            base.OnModelCreating(modelBuilder);
        }

        public void Commit()
        {
            SaveChanges();
        }
    }
}
