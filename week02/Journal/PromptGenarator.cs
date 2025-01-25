using System;

public class PromptGenerator()
{

    public readonly List<string>_prompts = new List<string>
    {
        "How and when did you see the hand of God in my life today? ", "Tell one thing you will want to remember about today: ", "What were the small miracles in your day? ", "With who did you have a meaningful time today? ", "What is a important lesson you want to keep from today? "
    };
    public static Random _rnd = new Random();
    public int prompIndex = _rnd.Next(0,5);

    public string GetRandomPrompt()
    {

        Random randPromp = new Random();
        string prompt = _prompts[randPromp.Next(_prompts.Count)];
        return prompt;

    }

}




