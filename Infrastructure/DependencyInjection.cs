using FoodLog.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FoodLog.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<Context>();

            services.AddSingleton<IContext, Context>();
            services.AddSingleton<IDateTime, MachineDateTime>();

            return services;
        }
    }
}
