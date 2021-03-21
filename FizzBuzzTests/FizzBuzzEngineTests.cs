using FizzBuzz;
using FizzBuzz.RulesPattern;
using FizzBuzz.SpecificationPattern;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzEngineTests
    {
        [Fact]
        public void PrintRulesResults_InputNotContainsSeven_ShoudlNotContainBarRule()
        {
            int number = 5;
            FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine(Rules);
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

            FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine(Rules);
            var stringOutput = new StringOutput();

            fizzBuzzEngine.PrintRulesResults(stringOutput, number);
            var output = stringOutput.Output;

            var ruleNames = new HashSet<string>()
            {
                "Bar",
                "Foo",
                "Fizz",
                "Buzz"
            };

            var res = output;
            foreach (var rule in ruleNames)
            {
                Assert.Contains(rule, res);
            }
        }


        private List<IRule<int>> Rules =>  new List<IRule<int>>
        {
                new FizzRule(),
                new BuzzRule(),
                new BarRule(),
                new FooRule()
        };

    }
}
