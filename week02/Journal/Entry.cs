using System;

public class Entry
{
    public string DateText { get; set; }
    public string PromptText { get; set; }
    public string ResponseText { get; set; }
    private const string Separator = "~|~";

    public Entry(string date, string prompt, string response)
    {
        DateText = date;
        PromptText = prompt;
        ResponseText = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {DateText}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {ResponseText}");
        Console.WriteLine("----");
    }

    public string GetSaveString()
    {
        return $"{DateText}{Separator}{PromptText}{Separator}{ResponseText}";
    }

    public static Entry FromSaveString(string saveString)
    {
        string[] parts = saveString.Split(new[] { Separator }, StringSplitOptions.None);
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        return null;
    }
}