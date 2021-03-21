using FizzBuzz;
using System.Text;

namespace FizzBuzzTests
{
    public class StringOutput : IOutput
    {
        private StringBuilder _str = new StringBuilder();
        public string Output =>  _str.ToString();
        public void Print(string s)
        {
            _str.Append(s);
        }
    }
}
