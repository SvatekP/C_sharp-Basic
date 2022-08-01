using System;

// Basic number guesser, checker if number is entered is missing, play again is missing

namespace NumberGuesser
{
    internal class Program
    {
        static void logo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAutor = "PavelS";
            Console.Clear();
             Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAutor);
            Console.WriteLine("----------------------------------------\n");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            logo();

            Console.WriteLine("What is your name?");
            string player = Console.ReadLine();

            logo();
            Console.WriteLine("Hello " + player + " let's play a game.\n");
            Console.WriteLine("Guess a number between 1 and 999:");


            // Set random correct number
            Random random = new Random();
            int correctNumber = random.Next(1, 999);

            int guess = 0;

            while (guess != correctNumber)
            {
                string input = Console.ReadLine();

                // Transfer string to Int
                guess = Int32.Parse(input);

                if(guess != correctNumber)
                {
                    logo();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}, {1} is not correct number, try again.", player, guess);
                    Console.ResetColor();
                    if(correctNumber > guess)
                    {
                        Console.WriteLine("The correct number is higher.");
                    }
                    if (correctNumber < guess)
                    {
                        Console.WriteLine("The correct number is lower.");
                    }
                }
            }

            logo();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(player + ", yes " + correctNumber + " is the correct number.\n");
        }
    }
}
