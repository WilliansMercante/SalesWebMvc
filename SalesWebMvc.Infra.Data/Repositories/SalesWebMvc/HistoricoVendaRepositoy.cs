using SalesWebMvc.Dominio.Entidades.SalesWebMvc;
using SalesWebMvc.Dominio.Interfaces.SalesWebMvc;
using SalesWebMvc.Infra.Data.Context;

namespace SalesWebMvc.Infra.Data.Repositories.SalesWebMvc
{
    public sealed class HistoricoVendaRepositoy : RepositoryBase<HistoricoVendasEntity, SalesWebMvcContext>, IHistoricoVendaRepository
    {
        public HistoricoVendaRepositoy(SalesWebMvcContext context) : base(context)
        {
        }

    
    }
}
