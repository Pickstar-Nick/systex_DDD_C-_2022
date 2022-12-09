using Microsoft.Extensions.DependencyInjection;
using Together.Appliction.Services;

namespace Together.Appliction;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IEventService,EventService>();
        return services;
    }
}