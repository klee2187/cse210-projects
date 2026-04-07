using System.Runtime;
using System.Security.Authentication;

public abstract class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }

    public string GetEventType()
    {
        return _type;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
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

    public abstract void DisplayAllDetails();

    public void DisplayShortDescription()
    {
        Console.WriteLine($"{_type}\n{_title}\n{_date}\n\n");
    }

}