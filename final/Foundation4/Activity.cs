public abstract class Activity 
{
    private string _date;
    private int _amountOfTime; 

    public Activity(string date, int amountOfTime)
    {
        _date = date;
        _amountOfTime = amountOfTime;         
    }

    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_amountOfTime} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile"; 
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public int GetAmountOfTime()
    {
        return _amountOfTime; 
    }
}