using FizzBuzz.SpecificationPattern;
using System;

namespace FizzBuzz.RulesPattern
{
    public class GenericRule : IRule<int>
    {
        private readonly string _value;
        private readonly Func<int, bool> _isMatch;
        public GenericRule(string value, Func<int, bool> isMatch)
        {
            _value = value;
            _isMatch = isMatch;
        }

        public string Apply()
        {
            return _value;
        }

        public bool IsMatch(int number)
        {
            return _isMatch(number);
        }
    }
}
