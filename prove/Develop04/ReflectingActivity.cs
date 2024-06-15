using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class ReflectingActivity : Activity
{

    public ReflectingActivity(string name, string description) : base(name, description)
    {
 
    }
    
    public string ReflectingPromptGenerator()
    {
        Random rnd = new Random();

        string[] _reflectingPrompts = 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."

        };
        int index = rnd.Next(_reflectingPrompts.Length);
        return _reflectingPrompts[index]; 
    }
    public string ReflectingQuestionGenerator()
    {
        Random rnd = new Random(); 

        string[] _questionPrompts = 
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        int index = rnd.Next(_questionPrompts.Length);
        return _questionPrompts[index]; 
    }
    // public void ReflectionCountdown()
    // {
    //     for (int i = 5; i > 0; i--)
    //     {
    //         Console.Write(i);
    //         Thread.Sleep(1000);
    //         Console.Write("\b \b"); 
    //     }
    // }

    public void Reflect()
    {
        StartingMessage(); 
        GetReady();
        Spinner();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---{ReflectingPromptGenerator()} ---");
        Console.WriteLine(); 
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine(); 
        Console.WriteLine(); 
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        CountDownTimer();
        Console.Clear(); 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration); 
        while (DateTime.Now < endTime)
        {
            
            Console.WriteLine();
            Console.Write($">{ReflectingQuestionGenerator()}");
            SlowSpinner();

        }
        WellDone();
        Spinner(); 
        CompletedDuration();
    }

}