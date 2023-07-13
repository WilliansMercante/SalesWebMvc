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
    public sealed class HistoricoVendaApp : IHistoricoVendaApp
    {
        private readonly IMapper _mapper = MapperConfig.RegisterMappers();
        private readonly IHistoricoVendaRepository _HistoricoVendaRepository;
        private readonly IUnitOfWork<SalesWebMvcContext> _unitOfWork;


        public HistoricoVendaApp(IHistoricoVendaRepository  historicoVendaRepository)
        {
            _HistoricoVendaRepository = historicoVendaRepository;
        }

        public void AdicionarHistoricoVenda(HistoricoVendaViewModel historico)
        {
            var HistoricoVendaEntity = _mapper.Map<HistoricoVendaEntity>(historico);
            _HistoricoVendaRepository.Incluir(HistoricoVendaEntity);
            _unitOfWork.Commit();
        }

        public IEnumerable<HistoricoVendaViewModel> Listar()
        {
            var lstHistoricoVendaEntity = _HistoricoVendaRepository.Listar();
            var lstHistoricoVendaVM = _mapper.Map<IEnumerable<HistoricoVendaViewModel>>(lstHistoricoVendaEntity);
            return lstHistoricoVendaVM;
        }

        public HistoricoVendaViewModel ConsultarPorId(int id)
        {
            var HistoricoVendaEntity = _HistoricoVendaRepository.ConsultarPorId(id);
            return _mapper.Map<HistoricoVendaViewModel>(HistoricoVendaEntity);

        }

        public void Incluir(HistoricoVendaViewModel historico)
        {
            var historicoVendaEntity = _mapper.Map<HistoricoVendaEntity>(historico);
            _HistoricoVendaRepository.Incluir(historicoVendaEntity);
            _unitOfWork.Commit();
        }
    }
}
