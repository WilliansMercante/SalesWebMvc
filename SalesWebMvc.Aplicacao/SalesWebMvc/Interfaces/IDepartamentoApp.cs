using SalesWebMvc.ViewModels.SalesWebMvc;

namespace SalesWebMvc.Aplicacao.SalesWebMvc.Interfaces
{

    public interface IDepartamentoApp
    {
        void AdicionarVendedor(DepartamentoViewModel obj);
        IEnumerable<DepartamentoViewModel> Listar();
        DepartamentoViewModel ConsultarPorId(int id);
        void Inativar(int id);
    }
}
