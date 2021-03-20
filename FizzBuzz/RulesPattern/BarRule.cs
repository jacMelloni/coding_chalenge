using FizzBuzz.SpecificationPattern;

namespace FizzBuzz.RulesPattern
{
    public class BarRule : IRule<int>
    {
        private static readonly string value = "Bar";
        public string Apply()
        {
            return value;
        }

        public bool IsMatch(int number)
        {
            return number % 7 == 0;
        }
    }
}
