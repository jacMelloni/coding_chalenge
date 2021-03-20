namespace FizzBuzz.SpecificationPattern
{
    public class FizzRule : IRule<int>
    {
        public string Apply()
        {
            return "Fizz";
        }

        public bool IsMatch(int number)
        {
            return number % 3 == 0;
        }
    }
}
