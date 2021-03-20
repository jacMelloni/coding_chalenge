using FizzBuzz.RulesPattern;
using FizzBuzz.SpecificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FizzBuzzTests
{
    public class FooRuleTests
    {
        [Fact]
        public void IsMath_InputMuliplicationByTenLessHundred_ReturnsFalse()
        {
            int number = 5;
            IRule<int> rule = new FooRule();
            Assert.False(rule.IsMatch(number));
        }

        [Fact]
        public void IsMath_InputMuliplicationByTenMoreHundred()
        {
            int number = 20;
            IRule<int> rule = new FooRule();
            Assert.True(rule.IsMatch(number));
        }
    }
}
