using System;

public class Entry
{

    //public DateOnly _date ;
    public DateTime _dateTime;
    public string _date = "";
    public string _promptText =  "";
    public string _entryText = ""; 

    public Entry(string response, string prompt)
    {

        _promptText = prompt;
        _entryText = response;
        _dateTime = DateTime.Now;
        _date = _dateTime.ToShortDateString();

    }
    

    public override string ToString()
    {
        // This will return as a string the whole content
        return $"Date: {_date} $Prompt: {_promptText} ${_entryText}";
        
    }

}