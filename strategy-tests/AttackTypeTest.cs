using FluentAssertions;
using strategy;
using Xunit;

namespace strategy_tests
{
    public class AttackTypeTest
    {
        [Theory]
        [InlineData(10, 110)]
        [InlineData(15, 115)]
        [InlineData(123, 223)]
        public void ReturnInt_WarriorAttack(int baseDamage, int expectedDamage)
        {
            Player player = new Warrior();
            int result = player.Attack(baseDamage);
            result.Should().Be(expectedDamage);
        }

        [Theory]
        [InlineData(10, 20)]
        [InlineData(15, 30)]
        [InlineData(123, 246)]
        public void ReturnInt_MageAttack(int baseDamage, int expectedDamage)
        {
            Player player = new Mage();
            int result = player.Attack(baseDamage);
            result.Should().Be(expectedDamage);
        }

        [Theory]
        [InlineData(10, 30)]
        [InlineData(15, 45)]
        [InlineData(100, 300)]
        public void ReturnInt_RangeAttack(int baseDamage, int expectedDamage)
        {
            Player player = new Ranger();
            int result = player.Attack(baseDamage);
            result.Should().Be(expectedDamage);
        }
    }
}
