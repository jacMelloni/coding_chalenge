using FizzBuzz.RulesPattern;
using FizzBuzz.SpecificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FizzBuzzTests
{
    public class BarRuleTests
    {
        [Fact]
        public void IsMath_InputNotDivisibleBySeven_ReturnsFalse()
        {
            int number = 3;
            IRule<int> rule = new BarRule();
            Assert.False(rule.IsMatch(number));
        }

        [Fact]
        public void IsMath_InputDivisibleBySeven()
        {
            int number = 14;
            IRule<int> rule = new BarRule();
            Assert.True(rule.IsMatch(number));
        }
    }
}
