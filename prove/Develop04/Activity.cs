using System;
using System.Runtime.InteropServices;

public class Activity
{
    protected string _name; 
    protected string _description; 
    protected int _duration; 

    public Activity(string name, string description)
    {
        _name = name; 
        _description = description; 
          
    }
    public int StartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n\nThis activity {_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine()); 
        return _duration;
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
    }
    public void WellDone()
    {
        Console.Clear(); 
        Console.WriteLine("Well Done!!"); 
    }
    public void CompletedDuration()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
    public void Spinner()
    {
         List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/"); 
        animationStrings.Add("-"); 
        animationStrings.Add("\\"); 
        animationStrings.Add("|"); 
        animationStrings.Add("/"); 
        animationStrings.Add("-"); 
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);
        
        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }   
        }
    }
    public void SlowSpinner()
    {
         List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/"); 
        animationStrings.Add("-"); 
        animationStrings.Add("\\"); 
        animationStrings.Add("|"); 
        animationStrings.Add("/"); 
        animationStrings.Add("-"); 
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);
        
        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }   
        }
    }
    public void CountDownTimer()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
    }

}