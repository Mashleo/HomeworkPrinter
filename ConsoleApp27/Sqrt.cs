using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class Sqrt: Shape
    {
        public Sqrt(int x1, int y1, char s1) : base(x1, y1, s1)
        {

        }


        public override void PrintFigure(int y1)
        {
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    Console.Write(symbol);

                }
                Console.WriteLine();
                for (int k = 0; k < y1; k++)
                {
                    Console.Write(" ");

                }
                

            }
            
        }
    }
}
