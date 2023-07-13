using SalesWebMvc.Dominio.Entidades.SalesWebMvc;

namespace SalesWebMvc.Dominio.Interfaces.SalesWebMvc
{
    public interface IHistoricoVendaRepository
    {
        IEnumerable<HistoricoVendaEntity> Listar();
        void Incluir(HistoricoVendaEntity obj);
        HistoricoVendaEntity ConsultarPorId(int id);
    }
}
