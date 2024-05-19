using Data.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Db
{
    public static class SQLServer
    {
        public static IServiceCollection AddSQLServerInfra(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<Context>(options => options
              .UseSqlServer(config.GetConnectionString("DEV"), x => x
                  .MigrationsAssembly(typeof(Context).Assembly.FullName)));

            return services;
        }
    }
}
