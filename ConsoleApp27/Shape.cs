using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    public abstract class Shape
    {
        public Shape(int x1, int y1, char s1)
        {
            hight = x1;
            width = y1;
            symbol = s1;
        }
        public int hight { get; set; }
        public int width { get; set; }
        public char symbol { get; set; }



        public virtual void PrintFigure(int y1)
        {
            
        }
    }
}
