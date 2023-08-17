using Events.EventsSourcing.Events;

namespace Events.EventsSourcing.Services;

public class SecondConsumerService : IEventConsumer 
{
    public SecondConsumerService(EventsBus eventsBus)
    {
        eventsBus.Subscribe(nameof(SecondEvent), Handler);
    }

    private void Handler()
    {
        Console.WriteLine("Second event handler called");
    }
}