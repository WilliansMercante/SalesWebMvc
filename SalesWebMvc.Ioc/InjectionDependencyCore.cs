using Microsoft.Extensions.DependencyInjection;

namespace SalesWebMvc.Ioc
{
    public static class InjectionDependencyCore
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            AddRepositories(services);
            AddServices(services);
            AddApplication(services);
        }


        private static void AddApplication(IServiceCollection services)
        {
            services.AddScoped<IBaseApp, BaseApp>();

            #region Ficha Catalográfica

            services.AddScoped<ILogVisualizacaoApp, LogVisualizacaoApp>();
            services.AddScoped<ITipoApp, TipoApp>();
            services.AddScoped<IFichaCatalograficaApp, FichaCatalograficaApp>();
            services.AddScoped<IStatusApp, StatusApp>();
            services.AddScoped<IVisualizadorApp, VisualizadorApp>();
            services.AddScoped<IClassificacaoItemApp, ClassificacaoItemApp>();
            services.AddScoped<INotificacaoApp, NotificacaoApp>();

            #endregion

            #region Corporativo

            services.AddScoped<IUnidadeApp, UnidadeApp>();

            #endregion

            #region Segurança

            services.AddScoped<IMenuApp, MenuApp>();
            services.AddScoped<IUsuarioApp, UsuarioApp>();
            services.AddScoped<IGrupoApp, GrupoApp>();
            services.AddScoped<IAceitacaoTermoUsoApp, AceitacaoTermoUsoApp>();

            #endregion

            #region Organizacional

            services.AddScoped<IEstruturaApp, EstruturaApp>();
            services.AddScoped<ITipoEstruturaApp, TipoEstruturaApp>();
            services.AddScoped<IModalidadeServicoApp, ModalidadeServicoApp>();

            #endregion
        }

        private static void AddServices(IServiceCollection services)
        {
            #region Ficha Catalográfica

            services.AddScoped<IFichaCatalograficaService, FichaCatalograficaService>();
            services.AddScoped<INotificacaoService, NotificacaoService>();

            #endregion
        }

        private static void AddRepositories(IServiceCollection services)
        {
            #region Configuracao

            services.AddScoped<IParametroRepository, ParametroRepository>();
            services.AddScoped<IMenuItemRepository, MenuItemRepository>();

            #endregion

            #region Mensagem

            services.AddScoped<IUnitOfWork<ConfiguracaoContext>, UnitOfWork<ConfiguracaoContext>>();
            services.AddScoped<IMensagemRepository, MensagemRepository>();
            services.AddScoped<IMensagemLidaRepository, MensagemLidaRepository>();

            #endregion

            #region Segurança

            services.AddScoped<IUnidadeRepository, UnidadeRepository>();
            services.AddScoped<IPrimeiroAcessoRepository, PrimeiroAcessoRepository>();
            services.AddScoped<ITrocarSenhaRepository, TrocarSenhaRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IGrupoRepository, GrupoRepository>();
            services.AddScoped<ILogAcessoRepository, LogAcessoRepository>();
            services.AddScoped<IAceitacaoTermoUsoRepository, AceitacaoTermoUsoRepository>();

            #endregion

            #region Corporativo

            services.AddScoped<Dominio.Corporativo.Repositories.IUnidadeRepository, Infra.Data.Repositories.Corporativo.UnidadeRepository>();

            #endregion

            #region Ficha Catalográfica

            services.AddScoped<IUnitOfWork<ArquivoContext>, UnitOfWork<ArquivoContext>>();
            services.AddScoped<ITipoRepository, TipoRepository>();
            services.AddScoped<ILogVisualizacaoRepository, LogVisualizacaoRepository>();
            services.AddScoped<IFichaCatalograficaRepository, FichaCatalograficaRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<IClassificacaoItemRepository, ClassificacaoItemRepository>();
            services.AddScoped<IMovimentacaoRepository, MovimentacaoRepository>();
            services.AddScoped<IAvaliadorRepository, AvaliadorRepository>();
            services.AddScoped<IAnalistaRepository, AnalistaRepository>();

            #endregion

            #region Contrato Gestão

            services.AddScoped<Dominio.ContratoGestao.Repositories.Interfaces.IUnidadeRepository, Infra.Data.Repositories.ContratoGestao.UnidadeRepository>();

            #endregion

            #region Organizacional

            services.AddScoped<IUnitOfWork<OrganizacionalContext>, UnitOfWork<OrganizacionalContext>>();
            services.AddScoped<IEstruturaRepository, EstruturaRepository>();
            services.AddScoped<ITipoEstruturaRepository, TipoEstruturaRepository>();
            services.AddScoped<IModalidadeServicoRepository, ModalidadeServicoRepository>();

            #endregion

            #region Shared

            services.AddScoped<IEmailRepository, Infra.Data.Repositories.Email.EmailRepository>();

            #endregion

        }
    }



}
