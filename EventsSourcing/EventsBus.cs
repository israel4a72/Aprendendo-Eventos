using Events.EventsSourcing.Interfaces;

namespace Events.EventsSourcing;
public class EventsBus
{
    private Dictionary<string, List<Action>> _eventSubscriptions = new();

    public void Subscribe(string eventName, Action handler)
    {
        if (!_eventSubscriptions.ContainsKey(eventName))
            _eventSubscriptions[eventName] = new List<Action>();

        _eventSubscriptions[eventName].Add(handler);
    }

    public void Unsubscribe(string eventName, Action handler)
    {
        if (_eventSubscriptions.TryGetValue(eventName, out var subscription))
            subscription.Remove(handler);
    }

    public void Publish(string eventName)
    {
        if (!_eventSubscriptions.ContainsKey(eventName)) return;
        foreach (var handler in _eventSubscriptions[eventName])
            handler.Invoke();
    }
}