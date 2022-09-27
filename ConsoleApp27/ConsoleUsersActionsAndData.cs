using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    public static class ConsoleUsersActionsAndData
    {
        public static string EnterText()
        {
            Console.Write("Enter Text - ");

            string enterText = Console.ReadLine();
            


            return enterText;
        }
        public static string UserChoise()
        {
            Console.Write(" Choise  figure: sqrt or triangl or text - ");

            string enterChoise = Console.ReadLine();
            if (enterChoise != "sqrt" && enterChoise != "triangl" && enterChoise != "text")
            {
                Console.WriteLine("return choise");               
                UserChoise();

            }
            

            return enterChoise;
        }
        public static char EnterSymbol()
        {
            Console.Write("Enter symbol - ");            
            char enterChar = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            return enterChar;
        }
        public static int EnterHight()
        {
            Console.Write("Enter hight - ");            
            int hight = Convert.ToInt32(Console.ReadLine());          

            return hight;
        }
        public static int  EnterWidth()
        {           
            Console.Write("Enter width - ");            
            int width = Convert.ToInt32(Console.ReadLine());            
            return  width;
        }
        public static int EnterX()
        {
            Console.Write("Enter X - ");
            int XOffset = Convert.ToInt32(Console.ReadLine());           
            return XOffset;
        }
        public static int EnterY()
        {
            Console.Write("Enter Y - ");
            int YOffset = Convert.ToInt32(Console.ReadLine());            
            return YOffset;
        }

    }
}
