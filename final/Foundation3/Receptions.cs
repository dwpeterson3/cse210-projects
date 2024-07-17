public class Receptions : Events 
{
    private string _email; 
    public Receptions(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email; 
    }
    public override string DisplayFullDetails()
    {
        return $"{base.DisplayFullDetails()}\nType: Reception\nEmail: {_email}";
    }

    public override string DisplayShortDescription()
    {
        return $"Reception: {_title}, Date: {_date}"; 
    }
}