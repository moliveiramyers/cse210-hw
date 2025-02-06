using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private bool _moreThanOneVerse;

    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _moreThanOneVerse = false;

    }

    public Reference (string book, int chapter, int verse, int endVerse)
    {
        
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _moreThanOneVerse = true;

    }

    public string GetDisplay()
    {
      
         if (_moreThanOneVerse == true)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }



}