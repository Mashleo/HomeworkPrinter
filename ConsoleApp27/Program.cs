using System;
using System.Collections.Generic;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = ConsoleUsersActionsAndData.EnterX();
            int y = ConsoleUsersActionsAndData.EnterY();
            int hight = ConsoleUsersActionsAndData.EnterHight();
            int width = ConsoleUsersActionsAndData.EnterWidth();
            char symbol = ConsoleUsersActionsAndData.EnterSymbol();
            IPrintable printer = new Printer();
            Console.WriteLine($" x - {x}, y - {y}, hight - {hight}, width - {width}, symbol - {symbol}");
            switch (ConsoleUsersActionsAndData.UserChoise())
            {
                case "sqrt":
                    Shape figure = new Sqrt(hight, width, symbol);

                    printer.Print(figure, y, x);
                    break;
                case "triangle":
                    Shape figure1 = new Triangle(hight, width, symbol);

                    printer.Print(figure1, y, x);
                    break;
                case "text":                    

                    printer.Print(ConsoleUsersActionsAndData.EnterText(), y, x);
                    break;
            } 
        }
    }
}
