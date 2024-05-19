using Data.Repositories;
using Domain.Interfaces;
using Domain.Models;
using Dto.Mappgins;
using Dto.Services;
using Dto.Services.IServices;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class IoCServices
    {
        public static IServiceCollection AddIoCServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseCrudGenerico<Categoria>), typeof(CategoriaRepository));
            services.AddScoped(typeof(IBaseCrudGenerico<Equipamento>), typeof(EquipamentoRepository));

            services.AddScoped<IEquipamentoServico, EquipamentoService>();
            services.AddScoped<ICategoriaServico, CategoriaService>();

            services.AddAutoMapper(typeof(ProfileMapping));

            return services;
        }
    }
}
