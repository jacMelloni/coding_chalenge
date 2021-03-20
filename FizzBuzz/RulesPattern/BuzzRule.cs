using FizzBuzz.SpecificationPattern;

namespace FizzBuzz.RulesPattern
{
    public class BuzzRule : IRule<int>
    {
        public string Apply()
        {
            return "Buzz";
        }

        public bool IsMatch(int number)
        {
            return number % 5 == 0;
        }
    }
}
