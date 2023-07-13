using Microsoft.Extensions.DependencyInjection;

using SalesWebMvc.Aplicacao.SalesWebMvc;
using SalesWebMvc.Aplicacao.SalesWebMvc.Interfaces;

namespace SalesWebMvc.Ioc
{
    public static class InjectionDependencyCore
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            AddRepositories(services);
            AddApplication(services);
        }

        private static void AddApplication(IServiceCollection services)
        {
            services.AddScoped<IVendedorApp, VendedorApp>();
            services.AddScoped<IHistoricoVendaApp, HistoricoVendaApp>();
            services.AddScoped<IDepartamentoApp, DepartamentoApp>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IVendedorApp, VendedorApp>();
            services.AddScoped<IHistoricoVendaApp, HistoricoVendaApp>();
            services.AddScoped<IDepartamentoApp, DepartamentoApp>();
        }
    }
}
