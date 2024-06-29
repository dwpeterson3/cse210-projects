using System;

class Program
{
    static void Main(string[] args)
    {
        ManageGoals manager = new ManageGoals(); 
        List<string> actions = new List<string> { "Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
        string action = "";
        int points = 0;  
        Console.WriteLine(); 
        Console.WriteLine($"You have {points} points."); 

        while (action != "6")
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
                manager.CreateNewGoal();     
            }

            else if (action == "2")
            {
                manager.ListGoals();
            }
            else if (action == "3")
            {
                manager.SaveGoals();
            }
            else if (action == "4")
            {
                manager.LoadGoals();
            }
            else if (action == "5")
            {
                manager.RecordEvent();
            }

        }
    }
}