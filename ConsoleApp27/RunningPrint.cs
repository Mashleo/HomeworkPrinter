using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
     public  class RunningPrint
    {
        public static void SwitchAndCase( )
        {
            IPrintable printer = new Printer();
            Shape shape;
            List<Shape> listShape = new List<Shape>(); 
           
            switch (ConsoleUsersActionsAndData.UserChoise())
            {
                case "sqrt":
                    shape = new Sqrt(ConsoleUsersActionsAndData.EnterHight(), ConsoleUsersActionsAndData.EnterWidth(), ConsoleUsersActionsAndData.EnterSymbol());
                    listShape.Add(shape);

                    printer.Print(shape, ConsoleUsersActionsAndData.EnterY(), ConsoleUsersActionsAndData.EnterX());
                    ConsoleUsersActionsAndData.ClearPrewievString();
                    SwitchAndCase();
                    break;
                case "triangl":
                    shape = new Triangle (ConsoleUsersActionsAndData.EnterHight(), ConsoleUsersActionsAndData.EnterWidth(), ConsoleUsersActionsAndData.EnterSymbol());
                    listShape.Add(shape);
                    printer.Print(shape, ConsoleUsersActionsAndData.EnterY(), ConsoleUsersActionsAndData.EnterX());
                    ConsoleUsersActionsAndData.ClearPrewievString();
                    SwitchAndCase();
                    break;
                case "text":

                    shape = new Text(0, 0, ConsoleUsersActionsAndData.EnterText());
                    listShape.Add(shape);
                    printer.Print(shape, ConsoleUsersActionsAndData.EnterY(), ConsoleUsersActionsAndData.EnterX());
                    ConsoleUsersActionsAndData.ClearPrewievString();
                    SwitchAndCase();
                    break;
            }
        }
    }
}
