using FizzBuzz.RulesPattern;
using FizzBuzz.SpecificationPattern;
using Xunit;

namespace FizzBuzzTests
{
    public class BuzzRuleTests
    {
        [Fact]
        public void IsMath_InputNotDivisibleByFive_ReturnsFalse()
        {
            int number = 4;
            IRule<int> rule = new BuzzRule();
            Assert.False(rule.IsMatch(number));
        }

        [Fact]
        public void IsMath_InputDivisibleByFive()
        {
            int number = 10;
            IRule<int> rule = new BuzzRule();
            Assert.True(rule.IsMatch(number));
        }
    }
}
