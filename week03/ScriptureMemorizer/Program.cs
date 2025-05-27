using System;

public class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        string userInput = "";

        const int WORDS_TO_HIDE_PER_TURN = 3;

        while (!scripture.IsCompletelyHidden() && userInput.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine("Press Enter to continue hiding words, or type 'quit' to finish.");
            Console.Write("> ");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(WORDS_TO_HIDE_PER_TURN);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("All words are hidden. Well done!");
        }
        else
        {
            Console.WriteLine("Program ended by user.");
        }
        
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}