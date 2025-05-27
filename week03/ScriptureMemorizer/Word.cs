using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public string Text { get => _text; }

    public bool IsHidden { get => _isHidden; }

    public Word(string text)
    {
        _text = text;      
        _isHidden = false;  
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}