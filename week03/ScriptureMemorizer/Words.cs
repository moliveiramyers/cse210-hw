using System;

public class Word
{
    private string _text ;
    private bool _isHidden;    

    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }
    public override string ToString()
    {
        return _isHidden ? new string('_',_text.Length) : _text;
    }

    public string Hide()
    {
        _isHidden = true;
        return new string('_',_text.Length);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplay()
    {
        return _text;
    }

}