using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
     public  class Printer : IPrintable
    {
        public  void Print(Shape nameShape, int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(' ');

                }
                if (i == x - 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            nameShape.PrintFigure(y);  
        }

        public void Print(string mesage, int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(' ');

                }
                if (i == x - 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(mesage);

        }
    }
}
