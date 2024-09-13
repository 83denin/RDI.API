using Microsoft.Extensions.DependencyInjection;
using RDI.BIBLIOTECA.Service;
using RDI.BIBLIOTECA.Repository;

namespace RDI.BIBLIOTECA
{
    public static class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IGeladeiraService, GeladeiraService>();
            services.AddScoped<IGeladeiraRepository, GeladeiraRepository>();
        }
    }
}
