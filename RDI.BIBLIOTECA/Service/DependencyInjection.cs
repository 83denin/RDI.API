using Microsoft.Extensions.DependencyInjection;
using RDI.BIBLIOTECA.Repository;
using RDI.BIBLIOTECA.Service;

public static class DependencyInjection
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IGeladeiraRepository, GeladeiraRepository>();
        services.AddScoped<IGeladeiraService, GeladeiraService>();
    }
}
