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
        public void ApplyRules_InputNotContainsSeven_ShoudlNotContainBarRule()
        {
            var rules = Rules;
            int number = 5;
            FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine();

            var output = fizzBuzzEngine.ApplyRules(rules, number).Where(x => x.Contains("Bar")).ToList();
            Assert.True(output.Count == 0);
        }

        [Fact]
        public void ApplyRules_InputFitsToAllRules_ReturnsCombinationsContainingAllRules()
        {
            int number = 11;
            var rules = Rules;
            
            FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine();           

            var output = fizzBuzzEngine.ApplyRules(rules, number);
            var expectedCount = 0;

            var ruleNames = new HashSet<string>()
            {
                "Bar",
                "Foo",
                "Fizz",
                "Buzz"
            };
            foreach (var ruleName in ruleNames)
            {
                foreach (var rule in output)
                {
                    if (rule.Contains(ruleName))
                    {
                        expectedCount++;
                    }
                }
            }
            
            Assert.True(expectedCount >= 4);
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
