using FizzBuzz.SpecificationPattern;

namespace FizzBuzz.RulesPattern
{
    public class BuzzRule : IRule<int>
    {
        private static readonly string value = "Buzz";
        public string Apply()
        {
            return value;
        }

        public bool IsMatch(int number)
        {
            return number % 5 == 0;
        }
    }
}
