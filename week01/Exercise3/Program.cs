using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Create a random number generator
        Random random = new Random();
        
        // Generate a random number between 1 and 100
        int magicNumber = random.Next(1, 101);

        // To keep track of the user's guess
        int guess = 0;

        // To count the number of guesses
        int guessCount = 0;

        Console.WriteLine("Guess the number between 1 and 100!");

        // Keep looping until the user guesses the correct number
        while (guess != magicNumber)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            // Try to convert the input to an integer
            if (int.TryParse(input, out guess))
            {
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher.");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the magic number!");
                    Console.WriteLine($"It took you {guessCount} guesses");
                }
            }    
        }
    }
}