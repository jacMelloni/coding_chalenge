﻿using FizzBuzz.RulesPattern;
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
        private List<IRule<int>> rules;
        public FizzBuzzEngine(List<IRule<int>> rules)
        {
            this.rules = rules;
        }

        public void PrintRulesResults(IOutput console, int limit = 100)
        {
            for (int number = 1; number <= limit; number++)
            {
                StringBuilder output = new StringBuilder();
                foreach (var rule in rules.Where(x => x.IsMatch(number)))
                {
                    output.Append(rule.Apply());
                }

                var res = $"{number}: {(output.Length == 0 ? number.ToString() : output.ToString())}";
                console.Print(res);
            }
        }
    }

    public class Program
    {
        private static List<IRule<int>> CreateRules()
        {
            return new List<IRule<int>>
            {
               new ModuloZeroRule("Fizz", 3),
               new ModuloZeroRule("Buzz", 5),
               new ModuloZeroRule("Bar", 7),
               new IsLuckyRule("Lucky!")
            };
        }

        public static void Main(string[] args)
        {
            ConsoleOutput console = new ConsoleOutput();
            FizzBuzzEngine engine = new FizzBuzzEngine(CreateRules());
            engine.PrintRulesResults(console, 30);

            Console.ReadLine();
        }
    }
}
