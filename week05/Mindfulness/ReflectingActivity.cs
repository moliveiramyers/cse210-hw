using System;
using System.Diagnostics;
using System.Threading;


public class ReflectingActivity : Activity
{
    private Random rdm = new Random();
    private List<int>_indexList = new List<int>();
    private List<string>_prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string>_questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity() : base()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestion();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int promptIndex = rdm.Next(_prompts.Count);
        return _prompts[promptIndex];
    }

    public string GetRandomQuestion()
    {
        string question = "";
        int questionIndex = rdm.Next(_questions.Count);        
        while (!_indexList.Contains(questionIndex))
        {
            question = _questions[questionIndex];
            _indexList.Add(questionIndex);
        }
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
        Console.WriteLine($"You begin in: ");
        ShowCountDown(3);
    }

    public void DisplayQuestion()
    {
        Console.WriteLine("Press enter to get another question!");
        Console.WriteLine(GetRandomQuestion());
        int timeDuration = GetDuration() * 1000;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds < timeDuration)
        {
            if (Console.KeyAvailable) 
            {          
                Console.WriteLine(GetRandomQuestion());
                string input = Console.ReadLine();            
            }
            Thread.Sleep(100);      
        }
    }

    public bool QuestionDisplayed()
    {
        return true;
    }


}