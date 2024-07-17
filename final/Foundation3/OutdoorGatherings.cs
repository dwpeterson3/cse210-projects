public class OutdoorGatherings : Events
{
    private string _weather;

    public OutdoorGatherings(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather; 
    }
    public override string DisplayFullDetails()
    {
        return $"{base.DisplayFullDetails()}\nType: Outdoor Gathering\nWeather: {_weather}";
    }
    public override string DisplayShortDescription()
    {
        return $"Outdoor Gathering: {_title}, Date: {_date}"; 
    }
}