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
            return new List<IRule<int>>
            {
                new ModuloZeroRule("Fizz", 3),
                new ModuloZeroRule("Buzz", 5),
                new ModuloZeroRule("Bar", 7),
                new IsLuckyRule("Lucky!")
            };
        }
    }
}
