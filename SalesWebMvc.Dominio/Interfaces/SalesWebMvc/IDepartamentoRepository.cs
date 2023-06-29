using SalesWebMvc.Dominio.Entidades.SalesWebMvc;

namespace SalesWebMvc.Dominio.Interfaces.SalesWebMvc
{
    public interface IDepartamentoRepository
    {
        IEnumerable<DepartamentoEntity> Listar();
        void Incluir(DepartamentoEntity obj);
        DepartamentoEntity ConsultarPorId(int id);
        void Inativar(int id);
    }
}
