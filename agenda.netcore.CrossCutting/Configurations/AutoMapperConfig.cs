using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace agenda.netcore.CrossCutting.Configurations
{
	public static class AutoMapperConfig
    {
        public static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AllowNullDestinationValues = true;
                //mc.AddProfile(new PessoaMapper());
            });
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
