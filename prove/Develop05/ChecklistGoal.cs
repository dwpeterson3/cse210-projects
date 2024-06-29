public class ChecklistGoal : Goal
{
    private int _timesAccomplished;
    private int  _numberOfTimes; 
    private int _bonusPoints; 

    public ChecklistGoal(string name, string description, int points, int numberOfTimes, int bonusPoints) : base(name, description, points)
    {
        _numberOfTimes = numberOfTimes;
        _bonusPoints = bonusPoints; 
        _timesAccomplished = 0;
    }

    public override int RecordEvent()
    {
        _timesAccomplished++; 
        if(_timesAccomplished == _numberOfTimes)
        {
            return _bonusPoints + _points;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _timesAccomplished >= _numberOfTimes;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete()?"X" : " ")}]{_name} ({_description}) -- Currently completed: {_timesAccomplished}/{_numberOfTimes}"; 
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: {_name}:{_description}:{_points}:{_timesAccomplished}:{_numberOfTimes}:{_bonusPoints}";
    }
    public static ChecklistGoal CreateFromString(string representation)
    {
        string[] parts = representation.Split(':');
        ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
        goal._timesAccomplished = int.Parse(parts[4]);
        return goal;
    }
}