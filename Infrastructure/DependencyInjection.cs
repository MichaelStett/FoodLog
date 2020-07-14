using FoodLog.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<Context>(opt =>
                opt.UseSqlServer(@"Server=.\;Database=FoodLog;Trusted_Connection=True;MultipleActiveResultSets=true")
            );

            services.AddSingleton<IContext, Context>();

            return services;
        }
    }
}
