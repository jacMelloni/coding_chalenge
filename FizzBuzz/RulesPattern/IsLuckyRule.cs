using FizzBuzz.SpecificationPattern;
using System;
using System.Linq;

namespace FizzBuzz.RulesPattern
{
    public class IsLuckyRule : IRule<int>
    {
        private readonly string _value;
        public IsLuckyRule(string value)
        {
            _value = value;
        }

        public string Apply()
        {
            return _value;
        }

        public bool IsMatch(int number)
        {
            if (number > 10)
            {
                var numberAsString = number.ToString();
                var distinctNumbers = numberAsString.Distinct().Count();
                if (distinctNumbers == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
