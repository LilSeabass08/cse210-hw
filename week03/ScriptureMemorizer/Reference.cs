using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse; 
    public string Book { get => _book; }

    public int Chapter { get => _chapter; }

    public int StartVerse { get => _startVerse; }

    public int? EndVerse { get => _endVerse; }

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        if (_endVerse == null)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}