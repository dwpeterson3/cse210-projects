using System;
//  I added an Activity counter to the menu options that counts how many activities that user performs. It also takes into consideration that checking your activity count does not count as an activity.

List<string> actions = new List<string> { "Start Breathing Activity", "Start Reflecting Activity", "Start Listing Activity", "Activity Count", "Quit" };
string action = "";
int activityCount = 0;

while (action != "5")
{

    Console.WriteLine();
    Console.WriteLine("Menu Options: ");

    for (int i = 0; i < actions.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {actions[i]}");
    }
    Console.Write("Select a choice from the menu: ");
    action = Console.ReadLine();

    if (action == "1")
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "will help you relax by walking you through breathing in and out slowly. Please clear your mind and focus on your breathing.");
        breathingActivity.Breathe();

    }
    else if (action == "2")
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        reflectingActivity.Reflect(); 
    }
    else if (action == "3")
    {
        ListingActivity listingActivity = new ListingActivity("Listing Activity","will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        listingActivity.List(); 
    }
    else if (action == "4")
    {
        if (activityCount == 1)
        {
           Console.Clear();
           Console.WriteLine();
           Console.WriteLine($"You have completed {activityCount} activity!"); 
        }
        else 
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"You have completed {activityCount} activities!");
        }
        activityCount += 1;
    }

}
