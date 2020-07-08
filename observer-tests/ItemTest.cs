using FluentAssertions;
using observer;
using Xunit;

namespace observer_tests
{
    public class ItemTest
    {
        [Fact]
        public void ReturnDouble_ToyPriceIs10()
        {
            Item item = new Toy();
            double result = item.Price;
            result.Should().Be(10.0);
        }

        [Fact]
        public void ReturnString_ToyNameIsToy()
        {
            Item item = new Toy();
            string result = item.Name;
            result.Should().Be("Toy");
        }

        [Fact]
        public void ReturnInt_AttachCustomersCountIs5()
        {
            Item item = new Toy();
            item.Attach(new Customer("Josh"));
            item.Attach(new Customer("John"));
            item.Attach(new Customer("Ben"));
            item.Attach(new Customer("Jenna"));
            item.Attach(new Customer("Christine"));

            int result = item.CustomerCount;
            result.Should().Be(5);
        }

        [Fact]
        public void ReturnInt_AttachRemoveCustomersCountIs3()
        {
            Item item = new Toy();
            Customer Josh = (Customer)item.Attach(new Customer("Josh"));
            Customer John = (Customer)item.Attach(new Customer("John"));
            Customer Ben = (Customer)item.Attach(new Customer("Ben"));
            Customer Jenna = (Customer)item.Attach(new Customer("Jenna"));
            Customer Christine = (Customer)item.Attach(new Customer("Christine"));

            item.Detach(Josh);
            item.Detach(Jenna);

            int result = item.CustomerCount;
            result.Should().Be(3);
        }
    }
}
