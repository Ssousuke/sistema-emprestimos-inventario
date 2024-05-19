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
            services.AddScoped(typeof(IBaseCrudGenerico<Categoria>), typeof(CRUDCategoriaRepository));
            services.AddScoped(typeof(IBaseCrudGenerico<Equipamento>), typeof(CRUDEquipamentoRepository));

            services.AddScoped<IBaseEquipamentoServico, BaseEquipamentoService>();
            services.AddScoped<IBaseCategoriaServico, BaseCategoriaService>();

            services.AddAutoMapper(typeof(ProfileMapping));

            return services;
        }
    }
}
