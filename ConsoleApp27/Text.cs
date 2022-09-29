using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class Text : Shape
    {
        public Text(int x1, int y1, string s1) : base(x1, y1, s1)
        {
            hight = x1;
            width = y1;
            symbol = s1;

        }
        public override void PrintFigure(int x, int y1)
        {
            Console.WriteLine(symbol);
        }
    }
}
