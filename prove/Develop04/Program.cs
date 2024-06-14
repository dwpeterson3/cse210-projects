using System;

List<string> actions = new List<string> { "Start Breathing Activity", "Start Reflecting Activity", "Start Listing Activity", "Quit" };
string action = "";

while (action != "4")
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

    }
}
