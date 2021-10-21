using agenda.netcore.Application;
using agenda.netcore.Application.Interface;
using agenda.netcore.CrossCutting.Configurations;
using agenda.netcore.Domain.Repositories;
using agenda.netcore.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace agenda.netcore.CrossCutting.IoC
{
	public static class DependencyResolver
	{
        public static void AddDependencyResolver(this IServiceCollection services)
        {
            RegisterApplications(services);
            RegisterRepositories(services);

            services.RegisterAutoMapper();
        }
        private static void RegisterApplications(IServiceCollection services)
        {
            services.AddTransient<IContatoApplication, ContatoApplication>();

        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IContatoRepository, ContatoRepository>();
        }
    }
}
