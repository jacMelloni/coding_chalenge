using FizzBuzz.SpecificationPattern;

namespace FizzBuzz.RulesPattern
{
    public class FooRule : IRule<int>
    {
        public string Apply()
        {
            return "Foo";
        }

        public bool IsMatch(int number)
        {
            return number * 10 > 100;
        }
    }
}
