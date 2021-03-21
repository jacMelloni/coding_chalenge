using System;
using System.Linq;
using System.Text;

/*
 
    *
   ***
  *****
 *******
*********

ACCEPTANCE CRITERIA:
Write a script to output this pyramid on console (with leading spaces)

*/
namespace Pyramid
{
    public class Program
    {
        private static readonly int offset = 8;

        private static void Pyramid(int height)
        {
            StringBuilder spaces = new StringBuilder(string.Concat(Enumerable.Repeat(' ', height - 1 + offset)));
            StringBuilder stars = new StringBuilder(2 * height - 1);
            stars.Append("*");

            for (int row = 1; row <= height; row++)
            {
                Console.Write(spaces);
                Console.WriteLine(stars);

                spaces.Remove(spaces.Length - 1, 1);
                stars.Append("**");
            }
        }

        public static void Main(string[] args)
        {
            Pyramid(10);
            Console.ReadLine();
        }
    }
}