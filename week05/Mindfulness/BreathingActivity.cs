using System;
using System.ComponentModel;
using System.Diagnostics;

public class BreathingActivinty : Activity
{

    public BreathingActivinty() : base()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");

    }

    public void Run()
    {
        DisplayStartingMessage();
        int timeDuration = GetDuration() * 1000;
        int breathe = 3;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.ElapsedMilliseconds < timeDuration)
        { 
            Console.WriteLine($"Breathe in...");
            ShowCountDown(breathe);
            Console.WriteLine($"Now breathe out...");     
            ShowCountDown(breathe);
            breathe++; //It will increase the time +1 each time it is run.

        }
        DisplayEndingMessage();
    }
}