using System;
using System.Drawing;
using static Pyramid.ConsoleHelper;

namespace Pyramid
{
    public class GraphicsHelper : IGraphicsHelper
    {
        public Font CreateFont(string name, int size)
        {
            return new Font(name, size);
        }

        public float MeasureStringWidth(string s, Font font)
        {
            SizeF result;
            using (var image = new Bitmap(1, 1))
            {
                using (var g = Graphics.FromImage(image))
                {
                    result = g.MeasureString(s, font);
                }
            }
            return result.Width;
        }

        public FontInfo GetCurrentFontInfo()
        {
            return ConsoleHelper.GetCurrentFontInfo();
        }
    }
}
