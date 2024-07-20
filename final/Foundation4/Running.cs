public class Running : Activity
{
    private double _distance;

    public Running(string date, int amountOfTime, int distance) : base(date, amountOfTime)
    {
        _distance = distance; 
    }
    public override double GetDistance()
    {
        return _distance; 
    }
    public override double GetSpeed()
    {
        return (_distance / GetAmountOfTime()) *60; 
    }
    public override double GetPace()
    {
        return GetAmountOfTime() / _distance; 
    }
}