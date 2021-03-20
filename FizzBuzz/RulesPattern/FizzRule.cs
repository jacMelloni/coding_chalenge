namespace FizzBuzz.SpecificationPattern
{
    public class FizzRule : IRule<int>
    {
        private static readonly string value = "Fizz";
        public string Apply()
        {
            return value;
        }

        public bool IsMatch(int number)
        {
            return number % 3 == 0;
        }
    }
}
