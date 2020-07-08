namespace observer
{
    public interface ICustomer
    {
        Item Item { get; set; }
        void Update(Item item);
    }
}