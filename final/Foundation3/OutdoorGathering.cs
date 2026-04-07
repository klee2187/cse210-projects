public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string type, string title, string description, string date, string time, Address address, string weather) : base(type, title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void DisplayAllDetails()
    {
        DisplayStandardDetails();

        Console.WriteLine($"Come enjoy some fresh air at this {GetEventType()}!\n");
        Console.WriteLine($"Event Details:");
        Console.WriteLine($"{GetTitle()}\n");
        Console.WriteLine($"{GetDescription()}\n");
        Console.WriteLine($"{GetDate()} {GetTime()}");
        Console.WriteLine($"{GetAddress()}\n");
        Console.WriteLine($"The weather forecast is {_weather}");

        DisplayShortDescription();
    }


}