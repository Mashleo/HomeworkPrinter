using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
   
    
    interface IPrintable
    {
        void Print(string mesage, int x, int y);
        void Print(Shape mesage, int x, int y);
    }
}
