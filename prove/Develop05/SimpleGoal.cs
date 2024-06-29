public class SimpleGoal : Goal
{
    public bool _isCompleted;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }
    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetDetailsString()
    {
        return $"[{(_isCompleted ? "X" : " ")}] {_name} ({_description})"; 
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal:{_name}:{_description}:{_points}:{_isCompleted}";
    }
    public static SimpleGoal CreateFromString(string representation)
    {
        string[] parts = representation.Split(':');
        SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
        goal._isCompleted = bool.Parse(parts[4]);
        return goal; 
    }
}