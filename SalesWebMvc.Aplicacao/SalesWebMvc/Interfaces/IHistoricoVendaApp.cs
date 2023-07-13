using SalesWebMvc.ViewModels.SalesWebMvc;

namespace SalesWebMvc.Aplicacao.SalesWebMvc.Interfaces
{
    public interface IHistoricoVendaApp
    {
        void Incluir(HistoricoVendaViewModel obj);
        IEnumerable<HistoricoVendaViewModel> Listar();
        HistoricoVendaViewModel ConsultarPorId(int id);
    }
}
