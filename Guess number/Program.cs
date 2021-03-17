using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeetings();
            RandomNumer(StRange(), NdRange());

            Console.ReadLine();
        }

        //Basic greetings
        static void Greeetings()
        {
            Console.WriteLine("Welcome to number guesser! Choose the range of the random number.");
        }

        // taking first number from user
        static int StRange()
        {
            Console.Write("st number: ");
            int st = Convert.ToInt32(Console.ReadLine());

            return st;
        }

        // taking second number from user
        static int NdRange()
        {
            Console.Write("nd number: ");
            int nd = Convert.ToInt32(Console.ReadLine());

            return nd;
        }

        //converting both number into random number
        static int RandomNumer(int x, int y)
        {
            int randomInt;

            while (x > y)
            {
                Console.WriteLine($"First number is greater than second. Please retype first number (Second number is {y})");
                x = StRange();
            }
            
            Random newRandom = new Random();
            randomInt = newRandom.Next(x, y);

            return randomInt;
        }
    }
}
