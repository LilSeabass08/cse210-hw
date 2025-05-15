// Journal.cs
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;
    private List<string> _randomPrompts;
    private Random _randomGenerator; 

    public Journal()
    {
        _entries = new List<Entry>();
        _randomGenerator = new Random();
        _randomPrompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What new skill or piece of knowledge did I acquire?",
            "Describe a moment today that made me smile.",
            "What challenge did I overcome today?",
            "Who am I grateful for today and why?"
        };
    }

    public void AddEntry(Entry newEntry)
    {
        if (newEntry != null)
        {
            _entries.Add(newEntry);
        }
    }

    public void DisplayAllEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Journal is empty. No entries to display.");
            return;
        }
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("--- End of Journal ---");
    }

    public string GetRandomPrompt()
    {
        if (_randomPrompts.Count == 0)
        {
            return "No prompts available.";
        }
        int index = _randomGenerator.Next(_randomPrompts.Count);
        return _randomPrompts[index];
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.GetSaveString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = Entry.FromSaveString(line);
            if (entry != null)
            {
                loadedEntries.Add(entry);
            }
        }
        _entries = loadedEntries;
    }
}