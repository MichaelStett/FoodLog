﻿using FoodLog.Application.Services;
using FoodLog.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IItemService, ItemService>();
            services.AddSingleton<INutrientService, NutrientService>();

            return services;
        }
    }
}
