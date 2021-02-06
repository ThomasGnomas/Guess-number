using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to number guesser! \nYou have 5 chances to guess the number from 1 to 100.");
            
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            for (int i = 1; i <=5; i++)
            {   
                if (i == 5)
                {
                    Console.Write($"\nIt's your last chance \n> ");
                }
                else
                {
                    Console.Write($"\nYour {i} chance \n> ");
                }
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == randomNumber)
                {
                Console.WriteLine("\nCorrect number");
                }
                else if (userGuess < randomNumber)
                {
                Console.WriteLine("Too small number");
                }
                else if (userGuess > randomNumber)
                {
                Console.WriteLine("Too big number");
                }
            }

            Console.ReadKey();
        }
    }
}
