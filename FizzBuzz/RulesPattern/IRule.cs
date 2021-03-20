namespace FizzBuzz.SpecificationPattern
{
    public interface IRule<T>
    {
        bool IsMatch(T o);
        string Apply();
    }
}
