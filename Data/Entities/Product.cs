using Events.Events;

namespace Events.Data.Entities
{
    public class Product
    {
        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        public delegate void NameUpdatedEventHandler(object source, ProductNameUpdatedEventArgs args);
        public event NameUpdatedEventHandler NameUpdated;

        public void UpdateName(string name)
        {
            Name = name;
            OnNameUpdated();
        }
        protected virtual void OnNameUpdated()
        {
            var e = new ProductNameUpdatedEventArgs
            {
                Domain = "Products"
            };
            NameUpdated?.Invoke(this, e);
        }
        public void WhenEventIsRaised(object sender, ProductNameUpdatedEventArgs args)
        => Console.WriteLine("Name updated to {0}", Name);
    }
}