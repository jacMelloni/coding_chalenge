using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using static Pyramid.ConsoleHelper;

namespace Pyramid
{
    public interface IGraphicsHelper
    {
        float MeasureStringWidth(string s, Font font);
        FontInfo GetCurrentFontInfo();
        Font CreateFont(string name, int size);
    }
}
