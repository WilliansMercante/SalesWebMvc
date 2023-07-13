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
    public sealed class VendedorApp : IVendedorApp
    {
        private readonly IMapper _mapper = MapperConfig.RegisterMappers();
        private readonly IVendedorRepository _vendedorRepository;
        private readonly IUnitOfWork<SalesWebMvcContext> _unitOfWork;


        public VendedorApp(IVendedorRepository vendedorRepository)
        {
            _vendedorRepository = vendedorRepository;
        }

        public void Incluir(VendedorViewModel vendedor)
        {
            var vendedorEntity = _mapper.Map<VendedorEntity>(vendedor);
            _vendedorRepository.Incluir(vendedorEntity);
            _unitOfWork.Commit();
        }

        public void Inativar(int id)
        {
            _vendedorRepository.Inativar(id);
            _unitOfWork.Commit();
        }

        public IEnumerable<VendedorViewModel> Listar()
        {
            var lstVendedorEntity = _vendedorRepository.Listar();
            var lstVendedorVM = _mapper.Map<IEnumerable<VendedorViewModel>>(lstVendedorEntity);
            return lstVendedorVM;
        }

        public VendedorViewModel ConsultarPorId(int id)
        {
            var vendedorEntity = _vendedorRepository.ConsultarPorId(id);
            return _mapper.Map<VendedorViewModel>(vendedorEntity);

        }
    }
}
