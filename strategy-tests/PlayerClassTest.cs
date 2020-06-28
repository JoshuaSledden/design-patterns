using FluentAssertions;
using strategy;
using Xunit;

namespace strategy_tests
{
    public class PlayerClassTest
    {
        [Fact]
        public void ReturnString_Warrior()
        {
            Player player = new Warrior();
            string result = player.Name;
            result.Should().Be("Warrior");
        }

        [Fact]
        public void ReturnString_Mage()
        {
            Player player = new Mage();
            string result = player.Name;
            result.Should().Be("Mage");
        }

        [Fact]
        public void ReturnString_Ranger()
        {
            Player player = new Ranger();
            string result = player.Name;
            result.Should().Be("Ranger");
        }
    }
}
