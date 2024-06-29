
public class Goals
{
    private List<Goal> _goals;
    private int _score;

    public Goals(int initialScore = 0)
    {
        _goals = new List<Goal>();
        _score = initialScore;
    }

    public int Score
    {
        get { return _score; }
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            int pointsEarned = goal.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Congratrulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
    }

        public void ListGoalDetails()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }
        public void ListGoalNames()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
            }
        }
        public List<string> GetStringRepresentations()
        {
            List<string> representations = new List<string>();
            foreach (Goal goal in _goals)
            {
                representations.Add(goal.GetStringRepresentation());
            }
            return representations;
        }
        public void LoadFromStringRepresentations(List<string> representations)
        {
            _goals.Clear();
            foreach (string r in representations)
            {
                string[] parts = r.Split(":");
                switch (parts[0])
                {
                    case "Simple Goal":
                        _goals.Add(SimpleGoal.CreateFromString(r));
                        break;
                    case "Eternal Goal":
                        _goals.Add(EternalGoal.CreateFromString(r));
                        break;
                    case "Checklist Goal":
                        _goals.Add(ChecklistGoal.CreateFromString(r));
                        break;
                }
            }
            Console.WriteLine($"Loaded {_goals.Count} goals."); 
        }
    }