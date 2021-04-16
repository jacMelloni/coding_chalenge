using FizzBuzz.SpecificationPattern;
using System;

namespace FizzBuzz.RulesPattern
{
    public class ModuloZeroRule : IRule<int>
    {
        private readonly string _value;
        private readonly int _dividend;
        public ModuloZeroRule(string value, int dividend)
        {
            if (dividend == 0)
            {
                throw new InvalidOperationException("Division by 0 is not possible");
            }

            _value = value;
            _dividend = dividend;
        }

        public string Apply()
        {
            return _value;
        }

        public bool IsMatch(int number)
        {
            return (number % _dividend) == 0;
        }
    }
}
