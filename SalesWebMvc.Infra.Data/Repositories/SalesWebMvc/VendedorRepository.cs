using SalesWebMvc.Dominio.Entidades.SalesWebMvc;
using SalesWebMvc.Dominio.Interfaces.SalesWebMvc;
using SalesWebMvc.Infra.Data.Context;

namespace SalesWebMvc.Infra.Data.Repositories.SalesWebMvc
{

    public sealed class VendedorRepository : RepositoryBase<VendedorEntity, SalesWebMvcContext>, IVendedorRepository
    {
        public VendedorRepository(SalesWebMvcContext context) : base(context)
        {
        }

        public void Inativar(int id)
        {
            var vendedorEntity = ConsultarPorId(id);
            vendedorEntity.FlAtivo = false;
        }      
    }
}
