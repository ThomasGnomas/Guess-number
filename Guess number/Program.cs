using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName = UserName();

            Console.ReadKey();
        }

        static void ColorMessage(ConsoleColor color, string text){
            Console.ForegroundColor = color;

            Console.WriteLine(text);

            Console.ResetColor();
        }

        static string UserName(){
            ColorMessage(ConsoleColor.Blue, "What's your name? ");

            string userName = Console.ReadLine();

            return userName;
        }
    }
}
