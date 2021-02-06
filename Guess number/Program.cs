using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            
            Console.Write("Your guess: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess == randomNumber)
            {
                Console.WriteLine("Correct number");
            }
            else
            {
                Console.WriteLine("Wrong number");
            }

            Console.ReadKey();
        }
    }
}
