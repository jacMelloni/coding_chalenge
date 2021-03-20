using FizzBuzz.SpecificationPattern;

namespace FizzBuzz.RulesPattern
{
    public class FooRule : IRule<int>
    {
        private static readonly string value = "Foo";
        public string Apply()
        {
            return value;
        }

        public bool IsMatch(int number)
        {
            return number * 10 > 100;
        }
    }
}
