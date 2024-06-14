using System;
class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void BreatheIn()
    {
        Console.WriteLine();
        Console.Write("Breathe In...");
    }
    public void BreatheOut()
    {
        Console.WriteLine();
        Console.Write("Now breathe Out...");
    }
    public void BreatheInCountdownTimer()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }

    }
    public void BreatheOutCountdownTimer()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

    public void Breathe()
    {
        StartingMessage();
        GetReady();
        Spinner();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration); 
        while (DateTime.Now < endTime)
        {
            BreatheIn() ; 
            BreatheInCountdownTimer();
            BreatheOut();
            BreatheOutCountdownTimer();
        }
        WellDone();
        Spinner(); 
        CompletedDuration(); 
    }
    
}
