using AutoMapper;

using SalesWebMvc.Dominio.Entidades.SalesWebMvc;
using SalesWebMvc.ViewModels.SalesWebMvc;

namespace SalesWebMvc.Aplicacao.Mappers
{
    public class MapperConfig
    {
        public static IMapper RegisterMappers()
        {
            var config = new MapperConfiguration(cfg =>
            {
                SalesWebMvc(cfg);
            });

            return config.CreateMapper();
        }

        private static void SalesWebMvc(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<VendedorEntity, VendedorViewModel>().ReverseMap();
            cfg.CreateMap<DepartamentoEntity, DepartamentoViewModel>().ReverseMap();
            cfg.CreateMap<HistoricoVendasEntity, HistoricoVendaViewModel>().ReverseMap();
        }
    }
}
