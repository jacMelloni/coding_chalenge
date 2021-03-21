using FizzBuzz;
using System.Text;

namespace FizzBuzzTests
{
    public class StringOutput : IOutput
    {
        private StringBuilder _str = new StringBuilder();
        public StringBuilder Output =>  _str;
        public void Print(string s)
        {
            _str.Append(s);
        }
    }
}
