using Segment.Model;
using System;
using System.Drawing;
using System.Linq;

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
        private static void Pyramid(int height)
        {
            int prev = 1;
            int offset = 8;
            for (int row = 1; row <= height; row++)
            {
                int spaces = height - row;
                int numberOfStars = prev;

                Console.WriteLine(new string(' ', spaces + offset) + 
                                  string.Concat(Enumerable.Repeat("*", numberOfStars)));
                prev += 2;
            }
        }
        
        public static void Main(string[] args)
        {
            Program pr = new Program();
            Pyramid(100);
            IGraphicsHelper gr = new GraphicsHelper();

            //FontInfo fontInfo = gr.GetCurrentFontInfo();
            //var font = gr.CreateFont(fontInfo.FontName, fontInfo.Size);

            //var s = string.Concat(Enumerable.Repeat("*", 120));
            //var length = gr.MeasureStringWidth(s, font);

        }
    }
}