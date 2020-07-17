using FoodLog.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FoodLog.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {

            services.AddDbContext<Context>(opt =>
            {
                opt.EnableSensitiveDataLogging();
                opt.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=FoodLog;Trusted_Connection=True;ConnectRetryCount=0;MultipleActiveResultSets=true");
            });

            services.AddSingleton<IContext, Context>();
            services.AddSingleton<IDateTime, MachineDateTime>();

            return services;
        }
    }
}
