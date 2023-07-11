using SalesWebMvc.Dominio.Entidades.SalesWebMvc;

namespace SalesWebMvc.Dominio.Interfaces.SalesWebMvc
{
    public interface IHistoricoVendaRepository
    {
        IEnumerable<HistoricoVendasEntity> Listar();
        void Incluir(HistoricoVendasEntity obj);
        HistoricoVendasEntity ConsultarPorId(int id);
    }
}
