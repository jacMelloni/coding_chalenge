using FizzBuzz;
using FizzBuzz.RulesPattern;
using FizzBuzz.SpecificationPattern;
using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzEngineTests
    {
        [Fact]
        public void PrintRulesResults_InputNotContainsSeven_ShoudlNotContainBarRule()
        {
            int number = 5;
            FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine(CreateRules());
            var stringOutput = new StringOutput();

            fizzBuzzEngine.PrintRulesResults(stringOutput, number);
            var output = stringOutput.Output;

            var expected = output.Contains("Bar");
            Assert.False(expected);
        }

        [Fact]
        public void PrintRulesResults_InputFitsToAllRules_ReturnsCombinationsContainingAllRules()
        {
            int number = 11;

            FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine(CreateRules());
            var stringOutput = new StringOutput();

            fizzBuzzEngine.PrintRulesResults(stringOutput, number);
            var output = stringOutput.Output;
            var expected = "1: 12: 23: Fizz4: 45: Buzz6: Fizz7: Bar8: 89: Fizz10: Buzz11: Foo";

            Assert.Equal(expected, output);
        }

        private List<IRule<int>> CreateRules()
        {
            Func<int, bool> fizzRule = (int number) => number % 3 == 0;
            Func<int, bool> buzzRule = (int number) => number % 5 == 0;
            Func<int, bool> barRule = (int number) => number % 7 == 0;
            Func<int, bool> fooRule = (int number) => number * 10 > 100;

            return new List<IRule<int>>
            {
                new GenericRule("Fizz", fizzRule),
                new GenericRule("Buzz", buzzRule),
                new GenericRule("Bar", barRule),
                new GenericRule("Foo", fooRule),
            };
        }
    }
}
