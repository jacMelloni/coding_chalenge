using FizzBuzz.RulesPattern;
using FizzBuzz.SpecificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 *
 * Given is the following FizzBuzz application which counts from 1 to 100 and outputs either the corresponding
 * number or the corresponding text if one of the following rules apply.
 * Rules:
 *  - dividable by 3 without a remainder -> Fizz
 *  - dividable by 5 without a remainder -> Buzz
 *  - dividable by 3 and 5 without a remainder -> FizzBuzz
 *
 * ACCEPTANCE CRITERIA:
 * Please refactor this code so that it can be easily extended in the future with other rules, such as
 * "if it is dividable by 7 without a remainder output Bar"
 * "if multiplied by 10 is larger than 100 output Foo"
 *
 */

namespace FizzBuzz
{
    public class FizzBuzzEngine
    {
        public List<string> ApplyRules(List<IRule<int>> rules, int limit = 100)
        {
            List<string> ls = new List<string>();

            for (int number = 1; number < limit; number++)
            {
                StringBuilder output = new StringBuilder();
                foreach (var rule in rules.Where(x => x.IsMatch(number)))
                {
                    output.Append(rule.Apply());
                }
                var res = $"{number}: { (output.Length == 0 ? number.ToString() : output.ToString())}";
                ls.Add(res);
            }

            return ls;
        }

        public void PrintRulesResults(List<string> output)
        {
            output.ForEach(x => Console.WriteLine(x));
        }
    }

    public class Program
    {
        private List<IRule<int>> CreateRules()
        {
            return new List<IRule<int>>
            {
                new FizzRule(),
                new BuzzRule(),
                new BarRule(),
                new FooRule()
            };
        }
        public static void Main(string[] args)
        {
            Program pr = new Program();
            FizzBuzzEngine engine = new FizzBuzzEngine();
            var rules = pr.CreateRules();
            var output = engine.ApplyRules(rules, 15);
            engine.PrintRulesResults(output);
            Console.ReadLine();
        }
    }
}
