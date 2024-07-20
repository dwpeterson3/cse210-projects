using System.Diagnostics.Contracts;

public class Bicycle : Activity
{
    private double _speed;

    public Bicycle(string date, int amountOfTime, int speed) : base(date, amountOfTime)
    {
        _speed = speed; 
    }
    public override double GetDistance()
    {
        return (_speed * GetAmountOfTime()) / 60;
    }
    public override double GetSpeed()
    {
        return _speed; 
    }
    public override double GetPace()
    {
        return 60 / _speed; 
    }
}