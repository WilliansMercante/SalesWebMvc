using SalesWebMvc.ViewModels.SalesWebMvc;

namespace SalesWebMvc.Aplicacao.SalesWebMvc.Interfaces
{
    public interface IVendedorApp
    {
        void Incluir(VendedorViewModel obj);
        IEnumerable<VendedorViewModel> Listar();
        VendedorViewModel ConsultarPorId(int id);
        void Inativar(int id);
    }
}
