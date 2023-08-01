namespace Events.Events
{
    public class ProductNameUpdatedEventArgs : EventArgs
    {
        public string Domain { get; set; } = null!;
    }
}