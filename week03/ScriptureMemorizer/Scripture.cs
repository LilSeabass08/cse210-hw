using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _randomGenerator;

    public Reference Ref { get => _reference; }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>(); 
        _randomGenerator = new Random();

        if (string.IsNullOrEmpty(text))
        {
            Console.WriteLine("Warning: Scripture text provided was empty.");
            return;
        }

        string[] wordArray = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string wordStr in wordArray)
        {
            _words.Add(new Word(wordStr));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        if (_words.Count == 0)
        {
            return;
        }

        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count == 0)
        {
            return;
        }

        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWords.Count == 0)
            {
                break;
            }

            int randomIndexInVisibleList = _randomGenerator.Next(0, visibleWords.Count);

            visibleWords[randomIndexInVisibleList].Hide();

            visibleWords.RemoveAt(randomIndexInVisibleList);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = ""; 

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()}\n{scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        if (_words.Count == 0)
        {
            return true;
        }

        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }

        return true;
    }
}