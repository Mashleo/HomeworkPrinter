using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
     public  class Printer : IPrintable
    {
        public  void Print(Shape nameShape, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            nameShape.PrintFigure(x,y);  
        }

        
    }
}
