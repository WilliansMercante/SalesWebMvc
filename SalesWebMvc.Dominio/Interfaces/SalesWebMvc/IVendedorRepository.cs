using SalesWebMvc.Dominio.Entidades.SalesWebMvc;

namespace SalesWebMvc.Dominio.Interfaces.SalesWebMvc
{
    public interface IVendedorRepository
    {
        IEnumerable<VendedorEntity> Listar();
        void Incluir(VendedorEntity obj);
        VendedorEntity ConsultarPorId(int id);
        void Inativar(int id);
    }
}
