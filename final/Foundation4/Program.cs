using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("19 Jul 2024", 60, 5); 
        Bicycle bicycle = new Bicycle("18 Jul 2024", 120, 23); 
        Swimming swimming = new Swimming("19 Jul 2024", 30, 50); 

        activities.Add(running);
        activities.Add(bicycle);
        activities.Add(swimming); 

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();  
        }

    }
}