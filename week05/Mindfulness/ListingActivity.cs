using System;
using System.Diagnostics;
using System.Threading;

public class ListingActivity : Activity
{
    private int _Count;
    private Random rdm = new Random();
    private List<string>_prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string>_userList = new List<string>();

    public ListingActivity() : base()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."); 
    }

     public void Run()
    {
        DisplayStartingMessage();
        DisplayRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
        
    }
    public string GetRandomPrompt()
    {
        int promptIndex = rdm.Next(_prompts.Count);
        return _prompts[promptIndex];
    }

    public void DisplayRandomPrompt()
    {
        Console.Write("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine("List as many responses you can to thr following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
    }
    public void GetListFromUser()
    {
        int timeDuration = GetDuration() * 1000;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while(stopwatch.ElapsedMilliseconds < timeDuration)
        {
            if (Console.KeyAvailable) // Check if user has pressed a key
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    _userList.Add(input);
                }
            }

            Thread.Sleep(100); 
        
        }
        Console.WriteLine($"You listed {CountAnswers()}");
    }
    
    public int CountAnswers()
    {
        _Count = _userList.Count;
        return _Count;
    }
}