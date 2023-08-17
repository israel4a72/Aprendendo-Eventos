namespace Events.EventsSourcing;

public class BaseEventArgs : EventArgs
{
    public string BaseEventArgument { get; set; }

    public BaseEventArgs(string baseEventArgument)
    {
        BaseEventArgument = baseEventArgument;
    }
}