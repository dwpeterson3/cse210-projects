public class ManageGoals
{
    private Goals _goals;
    public ManageGoals()
    {
        _goals = new Goals();
    }
    public void CreateNewGoal()
    {
        Console.WriteLine("\nThe types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                _goals.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int numberOfTimes = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());

                _goals.AddGoal(new ChecklistGoal(name, description, points, numberOfTimes, bonusPoints));
                break;
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are: ");
        _goals.ListGoalDetails();
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        List<string> representations = _goals.GetStringRepresentations();
        File.WriteAllLines(filename, representations);
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        List<string> representations = new List<string>(File.ReadAllLines(filename));
        _goals.LoadFromStringRepresentations(representations);
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        _goals.ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        _goals.RecordEvent(index);
    }
}