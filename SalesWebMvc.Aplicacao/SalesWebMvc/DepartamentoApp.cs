using AutoMapper;

using SalesWebMvc.Aplicacao.Mappers;
using SalesWebMvc.Aplicacao.SalesWebMvc.Interfaces;
using SalesWebMvc.Dominio;
using SalesWebMvc.Dominio.Entidades.SalesWebMvc;
using SalesWebMvc.Dominio.Interfaces.SalesWebMvc;
using SalesWebMvc.Infra.Data.Context;
using SalesWebMvc.ViewModels.SalesWebMvc;

namespace SalesWebMvc.Aplicacao.SalesWebMvc
{

    public sealed class DepartamentoApp : IDepartamentoApp
    {
        private readonly IMapper _mapper = MapperConfig.RegisterMappers();
        private readonly IDepartamentoRepository _departamentoRepository;
        private readonly IUnitOfWork<SalesWebMvcContext> _unitOfWork;

        public DepartamentoApp(IDepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        public void Incluir(DepartamentoViewModel departamento)
        {
            var departamentoEntity = _mapper.Map<DepartamentoEntity>(departamento);
            _departamentoRepository.Incluir(departamentoEntity);
            _unitOfWork.Commit();
        }

        public void Inativar(int id)
        {
            _departamentoRepository.Inativar(id);
            _unitOfWork.Commit();
        }

        public IEnumerable<DepartamentoViewModel> Listar()
        {
            var lstDepartamentoEntity = _departamentoRepository.Listar();
            var lstDepartamentoVM = _mapper.Map<IEnumerable<DepartamentoViewModel>>(lstDepartamentoEntity);
            return lstDepartamentoVM;
        }

        public DepartamentoViewModel ConsultarPorId(int id)
        {
            var departamentoEntity = _departamentoRepository.ConsultarPorId(id);
            return _mapper.Map<DepartamentoViewModel>(departamentoEntity);

        }
    }
}
