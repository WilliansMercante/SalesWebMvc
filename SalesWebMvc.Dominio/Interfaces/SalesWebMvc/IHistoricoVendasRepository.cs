using SalesWebMvc.Dominio.Entidades.SalesWebMvc;

namespace SalesWebMvc.Dominio.Interfaces.SalesWebMvc
{
    public interface IHistoricoVendasRepository
    {
        IEnumerable<HistoricoVendasEntity> Listar();
        void Incluir(HistoricoVendasEntity obj);
        HistoricoVendasEntity Obter(int id);
    }
}
