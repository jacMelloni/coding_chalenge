using System;

namespace FizzBuzz
{
    public class ConsoleOutput : IOutput
    {
        public void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
