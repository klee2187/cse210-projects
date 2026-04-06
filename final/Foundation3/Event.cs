using System.Runtime;

public abstract class Event
{
    private string _type;
    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;

    public Event(string type, string title, string description, DateOnly date, TimeOnly time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public DateOnly GetDateOnly()
    {
        return _date;
    }

    public TimeOnly GetTimeOnly()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_title}\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine($"{_date} {_time}\n");
        Console.WriteLine($"{_address}");
    }

    public abstract string FullDetails();
    public abstract string ShortDescription();

}