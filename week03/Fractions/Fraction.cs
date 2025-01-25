using System;
using System.IO.Compression;

public class Fractions 
{
    private int _topValue = 0;
    private int _bottomValue = 0;

    public Fractions()
    {
        _topValue = 1;
        _bottomValue = 1;

    }

    public Fractions(int wholeNumber)
    {

        _topValue = wholeNumber;
        _bottomValue = 1;

    }

    public Fractions(int topValue, int bottomValue)
    {

        _topValue = topValue;
        _bottomValue = bottomValue;

    }

    public string GetFractionString()
    {

        string text = $"{_topValue}/{_bottomValue}";
        return text;

    }

    public double GetDecimalValue()
    {
        
        return  (double)_topValue/ (double)_bottomValue;

    }

}