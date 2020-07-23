using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Presentation.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }
    }
}
