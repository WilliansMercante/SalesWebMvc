using SalesWebMvc.ViewModels.SalesWebMvc;

namespace SalesWebMvc.Aplicacao.SalesWebMvc.Interfaces
{
    public interface IVendedorApp
    {
        void AdicionarVendedor(VendedorViewModel obj);
        IEnumerable<VendedorViewModel> Listar();
        VendedorViewModel ConsultarPorId(int id);
        void Inativar(int id);
    }
}
