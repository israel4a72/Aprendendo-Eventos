using Events.EventsSourcing.Events;

namespace Events.EventsSourcing.Services;

public class FirstConsumerService : IEventConsumer
{
    public FirstConsumerService(EventsBus eventsBus)
    {
        eventsBus.Subscribe(nameof(FirstEvent), Handler);
    }

    private void Handler()
    {
        Console.WriteLine("First event handler called");
    }
}