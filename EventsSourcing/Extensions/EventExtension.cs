using Events.EventsSourcing.Services;

namespace Events.EventsSourcing.Extensions;

public static class EventExtension
{
    public static void AddEvents(this IServiceCollection services)
    {
        services.AddSingleton<EventsBus>();
        services.AddSingleton<FirstConsumerService>();
        services.AddSingleton<SecondConsumerService>();
        services.AddScoped<EventPublisherService>(); 
    }
}