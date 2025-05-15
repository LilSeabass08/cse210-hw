using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        bool keepRunning = true;

        Console.WriteLine("Welcome to Your Daily Journal!");

        while (keepRunning)
        {
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = myJournal.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {randomPrompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    Entry newEntry = new Entry(currentDate, randomPrompt, response);
                    myJournal.AddEntry(newEntry);
                    break;

                case "2":
                    myJournal.DisplayAllEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save (e.g., journal.txt): ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;

                case "4":
                    Console.Write("Enter filename to load (e.g., journal.txt): ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;

                case "5":
                    keepRunning = false;
                    Console.WriteLine("Exiting journal. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}