namespace Events.EventsSourcing;

public class ProductNameUpdatedEventArgs : EventArgs
{
    public ProductNameUpdatedEventArgs(string domain)
    {
        Domain = domain;
    }

    public string Domain { get; set; }
}