using Events.EventsSourcing.Events;

namespace Events.EventsSourcing.Services;

public class EventPublisherService
{
    private readonly EventsBus _eventsBus;
    
    public EventPublisherService(EventsBus eventsBus)
    {
        _eventsBus = eventsBus;
    }
    public void ExecuteFirstSomething()
    {
        // Code before event publishing
        
        _eventsBus.Publish(nameof(FirstEvent));
    }
    public void ExecuteSecondSomething()
    {
        // Code before event publishing
        
        _eventsBus.Publish(nameof(SecondEvent));
    }
}