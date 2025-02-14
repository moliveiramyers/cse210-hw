using System;
using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _descripton;
    private int _duration;
    private List<string>_animation = new List<string>
    {
        "|", "/", "-", "\\", "|", "-", "\\"
    };

    public Activity()
    {
        _name = "";
        _descripton = "description";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_descripton}\n");
        Console.Write("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Console.WriteLine();
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        int timeDuration = seconds * 1000;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
    
        while (stopwatch.ElapsedMilliseconds< timeDuration)
        {
            foreach( string s in _animation)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i>0; i-- )
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public int GetDuration()
    {
        return _duration;
    } 

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _descripton = description;
    }

    public string GetDescription()
    {
        return _descripton;
    }

}