using FoodLog.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FoodLog.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("FoodlogDatabase"));
                options.EnableSensitiveDataLogging();
            });

            services.AddTransient<IContext, Context>();
            services.AddSingleton<IDateTime, MachineDateTime>();

            return services;
        }
    }
}
