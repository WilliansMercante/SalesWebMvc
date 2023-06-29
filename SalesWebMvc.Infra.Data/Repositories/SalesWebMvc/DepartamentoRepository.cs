using SalesWebMvc.Dominio.Entidades.SalesWebMvc;
using SalesWebMvc.Dominio.Interfaces.SalesWebMvc;
using SalesWebMvc.Infra.Data.Context;

namespace SalesWebMvc.Infra.Data.Repositories.SalesWebMvc
{

    public sealed class DepartamentoRepository : RepositoryBase<DepartamentoEntity, SalesWebMvcContext>, IDepartamentoRepository
    {
        public DepartamentoRepository(SalesWebMvcContext context) : base(context)
        {
        }

        public void Inativar(int id)
        {
            var departamentoEntity = _context.Departamento.FirstOrDefault(p => p.Id == id);
            departamentoEntity.FlAtivo = false;
            Atualizar(departamentoEntity);
            _context.SaveChanges();
        }
    }
}
