using FluentAssertions;
using observer;
using Xunit;

namespace observer_tests
{
    public class CustomerTest
    {
        [Fact]
        public void ReturnString_ItemNameShouldBeBook()
        {
            Item item = new Book();
            Customer customer = new Customer("Josh");
            item.Attach(customer);
            string result = customer.Item.Name;
            result.Should().Be("Book");
        }
        [Fact]
        public void ReturnDouble_ItemUpdatePriceIs20()
        {
            Item item = new Toy();
            Customer customer = new Customer("Josh");
            item.Attach(customer);
            item.Price = 20.0;
            double result = customer.Item.Price;
            result.Should().Be(20.0);
        }
    }
}
