public class Swimming : Activity
{
    private int _numberOfLaps; 

    public Swimming(string date, int amountOfTime, int numberOfLaps) : base(date, amountOfTime)
    {
        _numberOfLaps = numberOfLaps; 
    }
    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetAmountOfTime()) * 60; 
    }

    public override double GetPace()
    {
        return GetAmountOfTime() / GetDistance(); 
    }
}