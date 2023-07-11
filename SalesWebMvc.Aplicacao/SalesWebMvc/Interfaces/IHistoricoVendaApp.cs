using SalesWebMvc.ViewModels.SalesWebMvc;

namespace SalesWebMvc.Aplicacao.SalesWebMvc.Interfaces
{
    public interface IHistoricoVendaApp
    {
        void AdicionarVendedor(HistoricoVendaViewModel obj);
        IEnumerable<HistoricoVendaViewModel> Listar();
        HistoricoVendaViewModel ConsultarPorId(int id);
        void Inativar(int id);
    }
}
