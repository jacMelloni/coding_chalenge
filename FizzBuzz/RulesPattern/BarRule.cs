using FizzBuzz.SpecificationPattern;

namespace FizzBuzz.RulesPattern
{
    public class BarRule : IRule<int>
    {
        public string Apply()
        {
            return "Bar";
        }

        public bool IsMatch(int number)
        {
            return number % 7 == 0;
        }
    }
}
