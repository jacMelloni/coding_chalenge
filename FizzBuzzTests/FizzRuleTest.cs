using FizzBuzz.SpecificationPattern;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzRuleTests
    {
        [Fact]
        public void IsMath_InputNotDivisibleByThree_ReturnsFalse()
        {
            int number = 4;
            IRule<int> rule = new FizzRule();
            Assert.False(rule.IsMatch(number));
        }

        [Fact]
        public void IsMath_InputDivisibleByThree()
        {
            int number = 9;
            IRule<int> rule = new FizzRule();
            Assert.True(rule.IsMatch(number));
        }
    }
}
