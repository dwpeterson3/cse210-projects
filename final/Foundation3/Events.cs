public class Events 
{
    protected string _title; 
    protected string _description; 
    protected string _date; 
    protected string _time; 
    protected Address _address; 
    
    public Events(string title, string description, string date, string time, Address address) 
    {
        _title = title; 
        _description = description;
        _date = date; 
        _time = time;
        _address = address; 
    }
    public virtual string DisplayStandardDetails() 
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }
    public virtual string DisplayFullDetails()
    {
        return DisplayStandardDetails(); 
    }
    public virtual string DisplayShortDescription()
    {
        return $"Event: {_title}, Date: {_date}"; 
    }
}